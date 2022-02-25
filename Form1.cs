using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class Form1 : Form
    {
        string ver = "v0.62";
        Rectangle old_size;
        FormWindowState old_windowState;
        IEnumerable<string> filepaths_pics;
        Stack history_st = new Stack();
        Random rnd = new Random();
        bool isFullscreen = false;
        bool isPlaying = false;
        int next_pic = -1;

        //prevent from turning off dispaly and going to sleep
        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

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
                btn_load_pics_Click(sender, e);

                //make pictureBox show pic-file
                try
                {
                    this.Text = "Simple Image Viewer - " + args[1];
                    pictureBox.ImageLocation = args[1];
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
            // deaktiviert Leertaste auf Form (genutzt um checkboxen zu tooglen)
            // Nutzt Links- Rechtspfeil um durch Bider zu navigieren
            // Nutzt Leertaste um Play/Pause to tooglen
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down)
                || keyData == Keys.Space)
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
                        case Keys.Space:
                            btn_play_Click(null, null);
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

        private void btn_load_pics_Click(object sender, EventArgs e)
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
            
            if (isPlaying)
            {
                timer1.Stop();
                timer1.Start();
            }

            show_next_pic();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                timer1.Stop();
                timer1.Start();
            }
            show_prev_pic();
        }

        private void show_next_pic()
        {
            if (filepaths_pics is null) return;

            PreventSleep();

            try
            {
                history_st.Push(next_pic);
                next_pic = cb_shuffle.Checked ? rnd.Next(filepaths_pics.Count()) : next_pic + 1;
                if (next_pic > filepaths_pics.Count() - 1) next_pic = 0;
                var filepath = filepaths_pics.ElementAt(next_pic);
                this.Text = "Simple Image Viewer - " + filepath;
                pictureBox.ImageLocation = filepath;
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

            PreventSleep();

            try
            {
                next_pic = (int)history_st.Pop();
                var filepath = filepaths_pics.ElementAt(next_pic);
                this.Text = "Simple Image Viewer - " + filepath;
                pictureBox.ImageLocation = filepath;
            }
            catch (Exception ex)
            {
                pictureBox.Image = pictureBox.ErrorImage;
                return;
            }
            //TextWriter txt = new StreamWriter("C:\\demo\\demo.txt");
            //StringBuilder sb = new StringBuilder("Range 0 to " + filepaths_pics.Count().ToString() + "\n\n");
            //var bla = filepaths_pics.Count();
            //for (int i = 0; i < 100; i++)
            //{
            //    sb.AppendLine(rnd.Next(bla).ToString());
            //}
            //txt.Write(sb.ToString());
            //txt.Close();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {   
            if (pictureBox.Image != null)
            {
                if (!isFullscreen)
                {   // go Fullscreen
                    //KEEP THIS ORDER!!
                    old_windowState = this.WindowState;
                    this.WindowState = FormWindowState.Normal;  // needed to hide Taskbar, when comming from maximized
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    old_size = pictureBox.Bounds;
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.BackColor = Color.Black;
                    isFullscreen = true;
                }
                else
                {   // go Normal
                    //KEEP THIS ORDER!!
                    pictureBox.Dock = DockStyle.None;
                    pictureBox.Bounds = old_size;
                    pictureBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                    this.WindowState = old_windowState;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    pictureBox.BackColor = Color.FromArgb(34,34,34);
                    isFullscreen = false;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && isFullscreen)
            {
                pictureBox_DoubleClick(sender, e);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            pictureBox.Select();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (filepaths_pics is null) return;

            isPlaying = !isPlaying;
            btn_play.BackgroundImage = isPlaying ? Image_Viewer.Properties.Resources.pause_logo : Image_Viewer.Properties.Resources.play_logo;
            nud_diaShowTime.Enabled = isPlaying;
            label3.ForeColor = isPlaying ? Color.White : Color.Gray;
            timer1.Interval = (int)nud_diaShowTime.Value * 1000;
            timer1.Enabled = isPlaying;

            if (isPlaying)
            {
                timer1.Start(); 
            }
            else 
            { 
                timer1.Stop();
            }
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
            string anleitung = $"\n\nKann sehr große Ordner (~200GB) verarbeiten und Unterordner einbinden\n\nUrsprünglicher Usecase: Zufällig Bilder aus einem großen Ordner mit vielen Unterordnern in Diashow anzeigen \n\ncwd trägt das aktuelle Verzeichnis ein.\n\nFilter enthält Dateiendungen.\nMehrere Filter mit Semikolon trennen\n\nBild-Datei lässt sich in Windows auch durch \"Öffnen mit...\" öffnen\n\n\nTastenbelegung:\n\nPfeiltasten Links, Rechts: \tDurch die Bilder skippen\nPfeiltasten Hoch, Runter: \tDrehung Rechts, Links\nDoppelklick auf Bild: \tVollbild ein/aus\nLeertaste\t\t\tDiashow anhalten/fortsetzen\n\n\n\n{ver}\nVinc";

            MessageBox.Show(anleitung, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PreventSleep()
        {
            // Prevent Idle-to-Sleep (monitor not affected) (see note above)
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
        }
    }
}
