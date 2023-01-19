
namespace SinemaBiletProje
{
    partial class seansListeleme
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seansListeleme));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.btnGeri = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 128);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 262);
			this.dataGridView1.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 16);
			this.label7.TabIndex = 25;
			this.label7.Text = "Geri";
			// 
			// btnGeri
			// 
			this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
			this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
			this.btnGeri.Location = new System.Drawing.Point(12, 12);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(90, 59);
			this.btnGeri.TabIndex = 24;
			this.btnGeri.UseVisualStyleBackColor = true;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(518, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 16);
			this.label1.TabIndex = 26;
			this.label1.Text = "Tarihe Göre Listele";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(654, 28);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(134, 22);
			this.dateTimePicker1.TabIndex = 27;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(585, 396);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(203, 35);
			this.button1.TabIndex = 28;
			this.button1.Text = "Tüm Kayıtları Listele";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// seansListeleme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.dataGridView1);
			this.Name = "seansListeleme";
			this.Text = "Seans Listeleme Sayfası";
			this.Load += new System.EventHandler(this.seansListeleme_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}