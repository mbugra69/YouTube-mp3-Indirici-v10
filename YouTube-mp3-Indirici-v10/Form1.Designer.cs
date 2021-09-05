namespace YouTube_mp3_Indirici_v10
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonMP3 = new System.Windows.Forms.RadioButton();
            this.radioButtonMP4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVideoName = new System.Windows.Forms.Label();
            this.labelVideoAd = new System.Windows.Forms.Label();
            this.buttonYapistir = new System.Windows.Forms.Button();
            this.pictureVidresim = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVidresim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelHeader.Location = new System.Drawing.Point(111, 47);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(490, 37);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "YouTube Mp3/MP4 Downloader v.1.0";
            this.labelHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Video Formatı:";
            // 
            // radioButtonMP3
            // 
            this.radioButtonMP3.AutoSize = true;
            this.radioButtonMP3.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMP3.Checked = true;
            this.radioButtonMP3.Location = new System.Drawing.Point(189, 293);
            this.radioButtonMP3.Name = "radioButtonMP3";
            this.radioButtonMP3.Size = new System.Drawing.Size(57, 21);
            this.radioButtonMP3.TabIndex = 4;
            this.radioButtonMP3.TabStop = true;
            this.radioButtonMP3.Text = "MP3";
            this.radioButtonMP3.UseVisualStyleBackColor = false;
            this.radioButtonMP3.CheckedChanged += new System.EventHandler(this.radioButtonMP3_CheckedChanged);
            // 
            // radioButtonMP4
            // 
            this.radioButtonMP4.AutoSize = true;
            this.radioButtonMP4.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMP4.Location = new System.Drawing.Point(261, 293);
            this.radioButtonMP4.Name = "radioButtonMP4";
            this.radioButtonMP4.Size = new System.Drawing.Size(57, 21);
            this.radioButtonMP4.TabIndex = 5;
            this.radioButtonMP4.Text = "MP4";
            this.radioButtonMP4.UseVisualStyleBackColor = false;
            this.radioButtonMP4.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(620, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "İndir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStatus.Location = new System.Drawing.Point(36, 327);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(491, 33);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(547, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "by mBk";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVideoName
            // 
            this.labelVideoName.BackColor = System.Drawing.Color.Transparent;
            this.labelVideoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVideoName.ForeColor = System.Drawing.Color.Red;
            this.labelVideoName.Location = new System.Drawing.Point(155, 197);
            this.labelVideoName.Name = "labelVideoName";
            this.labelVideoName.Size = new System.Drawing.Size(333, 59);
            this.labelVideoName.TabIndex = 11;
            this.labelVideoName.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelVideoAd
            // 
            this.labelVideoAd.BackColor = System.Drawing.Color.Transparent;
            this.labelVideoAd.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVideoAd.ForeColor = System.Drawing.Color.Black;
            this.labelVideoAd.Location = new System.Drawing.Point(37, 206);
            this.labelVideoAd.Name = "labelVideoAd";
            this.labelVideoAd.Size = new System.Drawing.Size(112, 23);
            this.labelVideoAd.TabIndex = 12;
            this.labelVideoAd.Text = "Video Ad:";
            // 
            // buttonYapistir
            // 
            this.buttonYapistir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonYapistir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYapistir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonYapistir.Location = new System.Drawing.Point(620, 249);
            this.buttonYapistir.Name = "buttonYapistir";
            this.buttonYapistir.Size = new System.Drawing.Size(256, 39);
            this.buttonYapistir.TabIndex = 13;
            this.buttonYapistir.Text = "Video İsim Getir";
            this.buttonYapistir.UseVisualStyleBackColor = false;
            this.buttonYapistir.Click += new System.EventHandler(this.buttonYapistir_Click);
            // 
            // pictureVidresim
            // 
            this.pictureVidresim.Image = ((System.Drawing.Image)(resources.GetObject("pictureVidresim.Image")));
            this.pictureVidresim.Location = new System.Drawing.Point(620, 47);
            this.pictureVidresim.Name = "pictureVidresim";
            this.pictureVidresim.Size = new System.Drawing.Size(247, 196);
            this.pictureVidresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVidresim.TabIndex = 14;
            this.pictureVidresim.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(888, 402);
            this.Controls.Add(this.pictureVidresim);
            this.Controls.Add(this.buttonYapistir);
            this.Controls.Add(this.labelVideoAd);
            this.Controls.Add(this.labelVideoName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonMP4);
            this.Controls.Add(this.radioButtonMP3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Mp3/Mp4 Downloader v.1.1 by mbk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureVidresim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonMP3;
        private System.Windows.Forms.RadioButton radioButtonMP4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVideoName;
        private System.Windows.Forms.Label labelVideoAd;
        private System.Windows.Forms.Button buttonYapistir;
        private System.Windows.Forms.PictureBox pictureVidresim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

