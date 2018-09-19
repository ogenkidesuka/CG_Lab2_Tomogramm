namespace TomogrammVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.glControl1 = new OpenTK.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BY_QUADSTRIP = new System.Windows.Forms.RadioButton();
            this.VSYNC = new System.Windows.Forms.CheckBox();
            this.BY_QUADS = new System.Windows.Forms.RadioButton();
            this.BY_TEXTURE = new System.Windows.Forms.RadioButton();
            this.LOADED = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.FPS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.VAL_MIN = new System.Windows.Forms.TextBox();
            this.VAL_WIDTH = new System.Windows.Forms.TextBox();
            this.VAL_LAY = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(12, 39);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(662, 447);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = true;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BY_QUADSTRIP);
            this.groupBox1.Controls.Add(this.VSYNC);
            this.groupBox1.Controls.Add(this.BY_QUADS);
            this.groupBox1.Controls.Add(this.BY_TEXTURE);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(679, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(184, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Параметры отрисовки ]";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BY_QUADSTRIP
            // 
            this.BY_QUADSTRIP.AutoSize = true;
            this.BY_QUADSTRIP.Location = new System.Drawing.Point(8, 66);
            this.BY_QUADSTRIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BY_QUADSTRIP.Name = "BY_QUADSTRIP";
            this.BY_QUADSTRIP.Size = new System.Drawing.Size(72, 17);
            this.BY_QUADSTRIP.TabIndex = 7;
            this.BY_QUADSTRIP.Text = "QuadStrip";
            this.BY_QUADSTRIP.UseVisualStyleBackColor = true;
            this.BY_QUADSTRIP.Click += new System.EventHandler(this.BY_QUADSTRIP_Click);
            // 
            // VSYNC
            // 
            this.VSYNC.AutoSize = true;
            this.VSYNC.Checked = true;
            this.VSYNC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VSYNC.Location = new System.Drawing.Point(8, 117);
            this.VSYNC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VSYNC.Name = "VSYNC";
            this.VSYNC.Size = new System.Drawing.Size(55, 17);
            this.VSYNC.TabIndex = 6;
            this.VSYNC.Text = "Vsync";
            this.VSYNC.UseVisualStyleBackColor = true;
            this.VSYNC.CheckedChanged += new System.EventHandler(this.VSYNC_CheckedChanged);
            // 
            // BY_QUADS
            // 
            this.BY_QUADS.AutoSize = true;
            this.BY_QUADS.Location = new System.Drawing.Point(8, 44);
            this.BY_QUADS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BY_QUADS.Name = "BY_QUADS";
            this.BY_QUADS.Size = new System.Drawing.Size(56, 17);
            this.BY_QUADS.TabIndex = 5;
            this.BY_QUADS.Text = "Quads";
            this.BY_QUADS.UseVisualStyleBackColor = true;
            this.BY_QUADS.CheckedChanged += new System.EventHandler(this.BY_QUADS_CheckedChanged);
            this.BY_QUADS.Click += new System.EventHandler(this.BY_QUADS_Click);
            // 
            // BY_TEXTURE
            // 
            this.BY_TEXTURE.AutoSize = true;
            this.BY_TEXTURE.Checked = true;
            this.BY_TEXTURE.Location = new System.Drawing.Point(8, 22);
            this.BY_TEXTURE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BY_TEXTURE.Name = "BY_TEXTURE";
            this.BY_TEXTURE.Size = new System.Drawing.Size(61, 17);
            this.BY_TEXTURE.TabIndex = 4;
            this.BY_TEXTURE.TabStop = true;
            this.BY_TEXTURE.Text = "Texture";
            this.BY_TEXTURE.UseVisualStyleBackColor = true;
            this.BY_TEXTURE.CheckedChanged += new System.EventHandler(this.BY_TEXTURE_CheckedChanged);
            this.BY_TEXTURE.Click += new System.EventHandler(this.BY_TEXTURE_Click);
            // 
            // LOADED
            // 
            this.LOADED.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LOADED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LOADED.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LOADED.Enabled = false;
            this.LOADED.Location = new System.Drawing.Point(944, 61);
            this.LOADED.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LOADED.Name = "LOADED";
            this.LOADED.ReadOnly = true;
            this.LOADED.Size = new System.Drawing.Size(184, 20);
            this.LOADED.TabIndex = 5;
            this.LOADED.Text = "ЗАГРУЗКА ЗАВЕРШЕНА";
            this.LOADED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LOADED.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(681, 454);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 76;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(169, 42);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // FPS
            // 
            this.FPS.BackColor = System.Drawing.Color.PapayaWhip;
            this.FPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FPS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FPS.Enabled = false;
            this.FPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FPS.Location = new System.Drawing.Point(679, 182);
            this.FPS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FPS.Name = "FPS";
            this.FPS.ReadOnly = true;
            this.FPS.Size = new System.Drawing.Size(184, 23);
            this.FPS.TabIndex = 7;
            this.FPS.Text = "FPS";
            this.FPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FPS.TextChanged += new System.EventHandler(this.FPS_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(679, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "[ СЛОИ ]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(681, 230);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar2.Maximum = 500;
            this.trackBar2.Minimum = -2600;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(184, 42);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(679, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "[ МИНИМУМ ]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(679, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "[ ШИРИНА ]";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(681, 299);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar3.Maximum = 3000;
            this.trackBar3.Minimum = -100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(184, 42);
            this.trackBar3.TabIndex = 11;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // VAL_MIN
            // 
            this.VAL_MIN.BackColor = System.Drawing.Color.OldLace;
            this.VAL_MIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VAL_MIN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.VAL_MIN.Enabled = false;
            this.VAL_MIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VAL_MIN.Location = new System.Drawing.Point(782, 205);
            this.VAL_MIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VAL_MIN.Name = "VAL_MIN";
            this.VAL_MIN.ReadOnly = true;
            this.VAL_MIN.Size = new System.Drawing.Size(83, 23);
            this.VAL_MIN.TabIndex = 13;
            this.VAL_MIN.Text = "VAL_MIN";
            this.VAL_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VAL_MIN.TextChanged += new System.EventHandler(this.VAL_MIN_TextChanged);
            // 
            // VAL_WIDTH
            // 
            this.VAL_WIDTH.BackColor = System.Drawing.Color.OldLace;
            this.VAL_WIDTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VAL_WIDTH.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.VAL_WIDTH.Enabled = false;
            this.VAL_WIDTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VAL_WIDTH.Location = new System.Drawing.Point(782, 272);
            this.VAL_WIDTH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VAL_WIDTH.Name = "VAL_WIDTH";
            this.VAL_WIDTH.ReadOnly = true;
            this.VAL_WIDTH.Size = new System.Drawing.Size(83, 23);
            this.VAL_WIDTH.TabIndex = 14;
            this.VAL_WIDTH.Text = "VAL_WIDTH";
            this.VAL_WIDTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VAL_WIDTH.TextChanged += new System.EventHandler(this.VAL_WIDTH_TextChanged);
            // 
            // VAL_LAY
            // 
            this.VAL_LAY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VAL_LAY.BackColor = System.Drawing.Color.OldLace;
            this.VAL_LAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VAL_LAY.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.VAL_LAY.Enabled = false;
            this.VAL_LAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VAL_LAY.Location = new System.Drawing.Point(782, 427);
            this.VAL_LAY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VAL_LAY.Name = "VAL_LAY";
            this.VAL_LAY.ReadOnly = true;
            this.VAL_LAY.Size = new System.Drawing.Size(83, 23);
            this.VAL_LAY.TabIndex = 15;
            this.VAL_LAY.Text = "VAL_LAY";
            this.VAL_LAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VAL_LAY.TextChanged += new System.EventHandler(this.VAL_LAY_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(879, 498);
            this.Controls.Add(this.VAL_LAY);
            this.Controls.Add(this.VAL_WIDTH);
            this.Controls.Add(this.VAL_MIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FPS);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LOADED);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(800, 525);
            this.Name = "Form1";
            this.Text = "CompGraphics | LabTwo | TomogrammVisualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox VSYNC;
        private System.Windows.Forms.RadioButton BY_QUADS;
        private System.Windows.Forms.RadioButton BY_TEXTURE;
        private System.Windows.Forms.TextBox LOADED;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox FPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.RadioButton BY_QUADSTRIP;
        private System.Windows.Forms.TextBox VAL_MIN;
        private System.Windows.Forms.TextBox VAL_WIDTH;
        private System.Windows.Forms.TextBox VAL_LAY;
    }
}

