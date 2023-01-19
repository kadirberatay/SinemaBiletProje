
namespace SinemaBiletProje
{
    partial class adminEkrani
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminEkrani));
			this.button2 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.btnFilmEkle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(59, 168);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(178, 44);
			this.button2.TabIndex = 3;
			this.button2.Text = "Personel Ekranı";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label12.Location = new System.Drawing.Point(120, 128);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 16);
			this.label12.TabIndex = 11;
			this.label12.Text = "Film Ekle";
			// 
			// btnFilmEkle
			// 
			this.btnFilmEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilmEkle.BackgroundImage")));
			this.btnFilmEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFilmEkle.Location = new System.Drawing.Point(107, 42);
			this.btnFilmEkle.Name = "btnFilmEkle";
			this.btnFilmEkle.Size = new System.Drawing.Size(86, 83);
			this.btnFilmEkle.TabIndex = 10;
			this.btnFilmEkle.UseVisualStyleBackColor = true;
			this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
			// 
			// adminEkrani
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 288);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnFilmEkle);
			this.Controls.Add(this.button2);
			this.Name = "adminEkrani";
			this.Text = "Admin Ekranı";
			this.Load += new System.EventHandler(this.adminEkrani_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFilmEkle;
    }
}