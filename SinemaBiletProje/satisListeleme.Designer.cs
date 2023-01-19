
namespace SinemaBiletProje
{
    partial class satisListeleme
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisListeleme));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnGeri = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 116);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 293);
			this.dataGridView1.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(668, 87);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(120, 22);
			this.dateTimePicker1.TabIndex = 2;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 420);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Toplam Satış";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(644, 412);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(144, 32);
			this.button3.TabIndex = 6;
			this.button3.Text = "Listele";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(43, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 16);
			this.label7.TabIndex = 27;
			this.label7.Text = "Geri";
			// 
			// btnGeri
			// 
			this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
			this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
			this.btnGeri.Location = new System.Drawing.Point(15, 30);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(90, 59);
			this.btnGeri.TabIndex = 26;
			this.btnGeri.UseVisualStyleBackColor = true;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// satisListeleme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "satisListeleme";
			this.Text = "Satış Listeleme Sayfası";
			this.Load += new System.EventHandler(this.satisListeleme_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGeri;
    }
}