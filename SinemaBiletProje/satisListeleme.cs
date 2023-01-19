using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletProje
{
    public partial class satisListeleme : Form
    {
        public satisListeleme()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.satisBilgiTableAdapter satislistesi = new sinemaTableAdapters.satisBilgiTableAdapter();

        private void satisListeleme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void ToplamUcretHesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["Ucret"].Value);
            }
           label1.Text = "Toplam Satis=" + ucrettoplami + " TL";
        }    

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = satislistesi.SatışListesi2();
            
        //    ToplamUcretHesapla();
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.SatışListesi2();

            ToplamUcretHesapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToplamUcretHesapla();
            dataGridView1.DataSource = satislistesi.SatışListesi2();

            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            biletSatisEkrani gecis = new biletSatisEkrani();
            this.Hide();
            gecis.ShowDialog();
        }
    }
}
