using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletProje
{
    public partial class seansListeleme : Form
    {
        public seansListeleme()
        {
            InitializeComponent();
        }

        sinemaTableAdapters.seansBilgiTableAdapter filmseansi = new sinemaTableAdapters.seansBilgiTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0C2AB06\\SQLEXPRESS;Initial Catalog=SinemaBiletOtomasyondbo;Integrated Security=True");
        DataTable tablo = new DataTable();

        private void SeansListesi(string sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            biletSatisEkrani gecis = new biletSatisEkrani();
            this.Hide();
            gecis.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select *from seansBilgi where tarih like '" + dateTimePicker1.Text + "'");

        }

        private void seansListeleme_Load(object sender, EventArgs e)
        {
            tablo.Clear();  

            SeansListesi("select *from seansBilgi where tarih like '" + dateTimePicker1.Text + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select *from seansBilgi");

        }
    }
}
