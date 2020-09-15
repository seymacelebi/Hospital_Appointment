namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnHastaGırıs = new System.Windows.Forms.Button();
            this.btnDoktorGırıs = new System.Windows.Forms.Button();
            this.btnSekreterGırıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHastaGırıs
            // 
            this.btnHastaGırıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaGırıs.BackgroundImage")));
            this.btnHastaGırıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaGırıs.Location = new System.Drawing.Point(15, 193);
            this.btnHastaGırıs.Name = "btnHastaGırıs";
            this.btnHastaGırıs.Size = new System.Drawing.Size(200, 175);
            this.btnHastaGırıs.TabIndex = 0;
            this.btnHastaGırıs.UseVisualStyleBackColor = true;
            this.btnHastaGırıs.Click += new System.EventHandler(this.btnHastaGırıs_Click);
            // 
            // btnDoktorGırıs
            // 
            this.btnDoktorGırıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGırıs.BackgroundImage")));
            this.btnDoktorGırıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorGırıs.Location = new System.Drawing.Point(259, 193);
            this.btnDoktorGırıs.Name = "btnDoktorGırıs";
            this.btnDoktorGırıs.Size = new System.Drawing.Size(200, 175);
            this.btnDoktorGırıs.TabIndex = 1;
            this.btnDoktorGırıs.UseVisualStyleBackColor = true;
            this.btnDoktorGırıs.Click += new System.EventHandler(this.btnDoktorGırıs_Click);
            // 
            // btnSekreterGırıs
            // 
            this.btnSekreterGırıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterGırıs.BackgroundImage")));
            this.btnSekreterGırıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterGırıs.Location = new System.Drawing.Point(502, 193);
            this.btnSekreterGırıs.Name = "btnSekreterGırıs";
            this.btnSekreterGırıs.Size = new System.Drawing.Size(200, 175);
            this.btnSekreterGırıs.TabIndex = 2;
            this.btnSekreterGırıs.UseVisualStyleBackColor = true;
            this.btnSekreterGırıs.Click += new System.EventHandler(this.btnSekreterGırıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(502, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(27, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "NP BEYİN HASTANESİ";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(710, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGırıs);
            this.Controls.Add(this.btnDoktorGırıs);
            this.Controls.Add(this.btnHastaGırıs);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "NP BEYİN HASTANESİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGırıs;
        private System.Windows.Forms.Button btnDoktorGırıs;
        private System.Windows.Forms.Button btnSekreterGırıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

