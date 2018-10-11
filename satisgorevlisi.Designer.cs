namespace ProfeTasarimDeneme
{
    partial class satisgorevlisi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.malzeme_alis = new System.Windows.Forms.PictureBox();
            this.urun_satis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzeme_alis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urun_satis)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProfeTasarimDeneme.Properties.Resources.Hosgeldiniz__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 135);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::ProfeTasarimDeneme.Properties.Resources.button_cancel_256;
            this.pictureBox10.Location = new System.Drawing.Point(520, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 35);
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // malzeme_alis
            // 
            this.malzeme_alis.BackColor = System.Drawing.Color.Transparent;
            this.malzeme_alis.Image = global::ProfeTasarimDeneme.Properties.Resources.malzalis;
            this.malzeme_alis.Location = new System.Drawing.Point(26, 194);
            this.malzeme_alis.Name = "malzeme_alis";
            this.malzeme_alis.Size = new System.Drawing.Size(208, 84);
            this.malzeme_alis.TabIndex = 13;
            this.malzeme_alis.TabStop = false;
            this.malzeme_alis.Click += new System.EventHandler(this.malzeme_alis_Click);
            // 
            // urun_satis
            // 
            this.urun_satis.BackColor = System.Drawing.Color.Transparent;
            this.urun_satis.Image = global::ProfeTasarimDeneme.Properties.Resources.satis;
            this.urun_satis.Location = new System.Drawing.Point(292, 194);
            this.urun_satis.Name = "urun_satis";
            this.urun_satis.Size = new System.Drawing.Size(208, 84);
            this.urun_satis.TabIndex = 14;
            this.urun_satis.TabStop = false;
            this.urun_satis.Click += new System.EventHandler(this.urun_satis_Click);
            // 
            // satisgorevlisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProfeTasarimDeneme.Properties.Resources.feather_3010848_1280;
            this.ClientSize = new System.Drawing.Size(559, 302);
            this.Controls.Add(this.urun_satis);
            this.Controls.Add(this.malzeme_alis);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "satisgorevlisi";
            this.Text = "satisgorevlisi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzeme_alis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urun_satis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox malzeme_alis;
        private System.Windows.Forms.PictureBox urun_satis;
    }
}