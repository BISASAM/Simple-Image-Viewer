﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class Form1 : Form
    {
        string ver = "v0.33";
        bool isFullscreen = false;
        int next_pic = -1;
        Rectangle old_size;
        Stack history_st = new Stack();
        IEnumerable<string> filepaths_pics;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set KeyPreview object to true to allow the form to process 
            // the key before the control with focus processes it.
            this.KeyPreview = true;

            // make sure pictureBox is the most upfront control
            pictureBox.BringToFront();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // check if called from picture file
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length >= 2 && Path.GetExtension(args[1]) != ".exe")
            {
                // trage pfad ein
                tb_path.Text = Path.GetDirectoryName(args[1]);

                //load pics of folder
                btn_show_pics_Click(sender, e);

                //make pictureBox show pic-file
                try
                {
                    pictureBox.ImageLocation = args[1];
                    this.Text = "Simple Image Viewer - " + args[1];
                }
                catch (Exception ex)
                {
                    pictureBox.Image = pictureBox.ErrorImage;
                    return;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // deaktiviert Pfeilnavigation auf Form, außer in Textboxen
            // Nutzt Links- Rechtspfeil um durch Bider zu navigieren
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {
                if (tb_path.Focused || tb_filter.Focused)
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
                else
                {
                    switch(keyData)
                    {
                        case Keys.Left: 
                            btn_back_Click(null, null);
                            break;
                        case Keys.Right:
                            btn_next_Click(null, null);
                            break;
                        case Keys.Up:
                            rotate_img(true);
                            break;
                        case Keys.Down:
                            rotate_img(false);
                            break;
                    }
                    return true;
                }
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btn_browse_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btn_show_pics_Click(object sender, EventArgs e)
        {
            // Get all files
            string folder_path = tb_path.Text.TrimEnd('\\', '/');
            
            try
            {
                next_pic = -1;
                var file_types = tb_filter.Text.Split(';').Select(entry => entry.Trim()).Where(entry => entry != null).ToArray();
                var recursive = cb_subfolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                filepaths_pics = Directory.EnumerateFiles(folder_path, "*.*", recursive).Where(file => file_types.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase)));
                show_next_pic();
                pictureBox.Select();  // set focus away from textboxes
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {   
            
            if (cb_diashow.Checked)
            {
                timer1.Stop();
                timer1.Start();
            }

            show_next_pic();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (cb_diashow.Checked)
            {
                timer1.Stop();
                timer1.Start();
            }
            show_prev_pic();
        }

        private void show_next_pic()
        {
            if (filepaths_pics is null) return;

            try
            {
                history_st.Push(next_pic);
                next_pic = cb_random.Checked ? rnd.Next(filepaths_pics.Count()) : next_pic + 1;
                if (next_pic > filepaths_pics.Count() - 1) next_pic = 0;
                var filepath = filepaths_pics.ElementAt(next_pic);
                pictureBox.ImageLocation = filepath;
                this.Text = "Simple Image Viewer - " + filepath;
            }
            catch (Exception ex)
            {
                pictureBox.Image = pictureBox.ErrorImage;
                return;
            }
        }

        private void show_prev_pic()
        {
            if (filepaths_pics is null) return;

            try
            {
                next_pic = (int)history_st.Pop();
                pictureBox.ImageLocation = filepaths_pics.ElementAt(next_pic);
            }
            catch (Exception ex)
            {
                pictureBox.Image = pictureBox.ErrorImage;
                return;
            }
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {   
            if (pictureBox.Image != null)
            {
                if (!isFullscreen)
                {
                    old_size = pictureBox.Bounds;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.BackColor = Color.Black;
                    isFullscreen = true;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    pictureBox.Dock = DockStyle.None;
                    pictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                    pictureBox.Bounds = old_size;
                    pictureBox.BackColor = Color.FromArgb(34,34,34);
                    isFullscreen = false;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {              
            if (e.KeyCode == Keys.Escape && isFullscreen)
            {
                pictureBox.Dock = DockStyle.None;
                pictureBox.BackColor = SystemColors.Control;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                isFullscreen = false;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            pictureBox.Select();
        }

        private void cb_diashow_CheckedChanged(object sender, EventArgs e)
        {
            nud_diaShowTime.Enabled = cb_diashow.Checked;
            timer1.Interval = (int)nud_diaShowTime.Value*1000;
            timer1.Enabled = cb_diashow.Checked;
        }

        private void nud_diaShowTime_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)nud_diaShowTime.Value * 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            show_next_pic();  
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            rotate_img(true);
        }

        private void rotate_img(bool cw)
        {
            if (pictureBox.Image == null) return;

            var img = pictureBox.Image;
            if (cw) img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox.Image = img;
        }

        private void btn_cwd_Click(object sender, EventArgs e)
        {   
            tb_path.Text = Directory.GetCurrentDirectory();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            string anleitung = $"\n\nKann sehr große Ordner (~200GB) verarbeiten und Unterordner einbinden\n\nUrsprünglicher Usecase: Zufällig Bilder aus einem großen Ordner mit vielen Unterordnern in Diashow anzeigen \n\ncwd trägt das aktuelle Verzeichnis ein.\n\nFilter enthält Dateiendungen.\nMehrere Filter mit Semikolon trennen\n\nBild-Datei lässt sich in Windows auch durch \"Öffnen mit...\" öffnen\n\n\nTastenbelegung:\n\nPfeiltasten Links, Rechts: \tDurch die Bilder skippen\nPfeiltasten Hoch, Runter: \tDrehung Rechts, Links\nDoppelklick auf Bild: \tVollbild ein/aus\n\n\n\n{ver}\nVinc";

            MessageBox.Show(anleitung, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
