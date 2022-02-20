namespace Image_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_show_pics = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.cb_subfolder = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.cb_random = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nud_diaShowTime = new System.Windows.Forms.NumericUpDown();
            this.cb_diashow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cwd = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_diaShowTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_show_pics
            // 
            this.btn_show_pics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_show_pics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_show_pics.FlatAppearance.BorderSize = 0;
            this.btn_show_pics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_show_pics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_pics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_pics.ForeColor = System.Drawing.Color.White;
            this.btn_show_pics.Location = new System.Drawing.Point(482, 69);
            this.btn_show_pics.Name = "btn_show_pics";
            this.btn_show_pics.Size = new System.Drawing.Size(112, 23);
            this.btn_show_pics.TabIndex = 0;
            this.btn_show_pics.Text = "Bilder anzeigen";
            this.btn_show_pics.UseVisualStyleBackColor = false;
            this.btn_show_pics.Click += new System.EventHandler(this.btn_show_pics_Click);
            // 
            // tb_path
            // 
            this.tb_path.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tb_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_path.ForeColor = System.Drawing.Color.White;
            this.tb_path.Location = new System.Drawing.Point(213, 20);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(263, 22);
            this.tb_path.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(482, 19);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(53, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click_1);
            // 
            // cb_subfolder
            // 
            this.cb_subfolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_subfolder.AutoSize = true;
            this.cb_subfolder.FlatAppearance.BorderSize = 0;
            this.cb_subfolder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cb_subfolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cb_subfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_subfolder.ForeColor = System.Drawing.Color.White;
            this.cb_subfolder.Location = new System.Drawing.Point(213, 44);
            this.cb_subfolder.Name = "cb_subfolder";
            this.cb_subfolder.Size = new System.Drawing.Size(163, 19);
            this.cb_subfolder.TabIndex = 3;
            this.cb_subfolder.Text = "Unterordner einbeziehen";
            this.cb_subfolder.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Location = new System.Drawing.Point(12, 109);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(760, 427);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(379, 552);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 34);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Vor";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter";
            // 
            // tb_filter
            // 
            this.tb_filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tb_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filter.ForeColor = System.Drawing.Color.White;
            this.tb_filter.Location = new System.Drawing.Point(213, 70);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(263, 22);
            this.tb_filter.TabIndex = 14;
            this.tb_filter.Text = "jpeg; jpg; png";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(298, 552);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 34);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cb_random
            // 
            this.cb_random.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_random.AutoSize = true;
            this.cb_random.FlatAppearance.BorderSize = 0;
            this.cb_random.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cb_random.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cb_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_random.ForeColor = System.Drawing.Color.White;
            this.cb_random.Location = new System.Drawing.Point(302, 602);
            this.cb_random.Name = "cb_random";
            this.cb_random.Size = new System.Drawing.Size(66, 20);
            this.cb_random.TabIndex = 16;
            this.cb_random.Text = "Shuffle";
            this.cb_random.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nud_diaShowTime
            // 
            this.nud_diaShowTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nud_diaShowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.nud_diaShowTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_diaShowTime.Enabled = false;
            this.nud_diaShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_diaShowTime.ForeColor = System.Drawing.Color.White;
            this.nud_diaShowTime.Location = new System.Drawing.Point(380, 626);
            this.nud_diaShowTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_diaShowTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_diaShowTime.Name = "nud_diaShowTime";
            this.nud_diaShowTime.Size = new System.Drawing.Size(46, 24);
            this.nud_diaShowTime.TabIndex = 18;
            this.nud_diaShowTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_diaShowTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_diaShowTime.ValueChanged += new System.EventHandler(this.nud_diaShowTime_ValueChanged);
            // 
            // cb_diashow
            // 
            this.cb_diashow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cb_diashow.AutoSize = true;
            this.cb_diashow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_diashow.ForeColor = System.Drawing.Color.White;
            this.cb_diashow.Location = new System.Drawing.Point(302, 630);
            this.cb_diashow.Name = "cb_diashow";
            this.cb_diashow.Size = new System.Drawing.Size(78, 20);
            this.cb_diashow.TabIndex = 19;
            this.cb_diashow.Text = "Diashow";
            this.cb_diashow.UseVisualStyleBackColor = true;
            this.cb_diashow.CheckedChanged += new System.EventHandler(this.cb_diashow_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(432, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sek.";
            // 
            // btn_info
            // 
            this.btn_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.Color.White;
            this.btn_info.Location = new System.Drawing.Point(3, 628);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(27, 28);
            this.btn_info.TabIndex = 21;
            this.btn_info.Text = "?";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_rotate
            // 
            this.btn_rotate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_rotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_rotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rotate.BackgroundImage")));
            this.btn_rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rotate.FlatAppearance.BorderSize = 0;
            this.btn_rotate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rotate.ForeColor = System.Drawing.Color.White;
            this.btn_rotate.Location = new System.Drawing.Point(469, 552);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(39, 34);
            this.btn_rotate.TabIndex = 22;
            this.btn_rotate.UseVisualStyleBackColor = false;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Verzeichnis";
            // 
            // btn_cwd
            // 
            this.btn_cwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_cwd.FlatAppearance.BorderSize = 0;
            this.btn_cwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_cwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cwd.ForeColor = System.Drawing.Color.White;
            this.btn_cwd.Location = new System.Drawing.Point(541, 19);
            this.btn_cwd.Name = "btn_cwd";
            this.btn_cwd.Size = new System.Drawing.Size(53, 23);
            this.btn_cwd.TabIndex = 24;
            this.btn_cwd.Text = "cwd";
            this.btn_cwd.UseVisualStyleBackColor = false;
            this.btn_cwd.Click += new System.EventHandler(this.btn_cwd_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btn_pause.BackgroundImage = global::Image_Viewer.Properties.Resources.pause_logo;
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pause.Enabled = false;
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.ForeColor = System.Drawing.Color.White;
            this.btn_pause.Location = new System.Drawing.Point(523, 552);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(39, 34);
            this.btn_pause.TabIndex = 25;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 659);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_cwd);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rotate);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.nud_diaShowTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_diashow);
            this.Controls.Add(this.cb_random);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_filter);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.cb_subfolder);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_show_pics);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(444, 564);
            this.Name = "Form1";
            this.Text = "Simple Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_diaShowTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_show_pics;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.CheckBox cb_subfolder;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.CheckBox cb_random;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nud_diaShowTime;
        private System.Windows.Forms.CheckBox cb_diashow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cwd;
        private System.Windows.Forms.Button btn_pause;
    }
}

