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
using System.Data.Sql;


namespace SinemaBiletProje
{
    public partial class seansEkleme : Form
    {
        public seansEkleme()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.seansBilgiTableAdapter filmseansi = new sinemaTableAdapters.seansBilgiTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0C2AB06\\SQLEXPRESS;Initial Catalog=SinemaBiletOtomasyondbo;Integrated Security=True");
        private void filmVeSalonGoster(ComboBox combo, string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());

            }
            baglanti.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            biletSatisEkrani gecis = new biletSatisEkrani();
            this.Hide();
            gecis.ShowDialog();
        }

        private void seansEkleme_Load(object sender, EventArgs e)
        {
            filmVeSalonGoster(comboFilm, "select * from filmBilgi", "filmAdi");
            filmVeSalonGoster(comboSalon, "select * from salonBilgi", "salonAdi");
        }
        private void Tarihi_Karşılaştır()
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from seansBilgi where salonAdi='" + comboSalon.Text + "'and tarih='" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }

            }
            baglanti.Close();
        }

        string seans = "";

        
       
        
        private void radioButtonSeciliyse()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            radioButtonSeciliyse();
            if (seans != "" /*&& !String.IsNullOrWhiteSpace(comboFilm.Text) && !String.IsNullOrWhiteSpace(comboSalon.Text)*/)
            {
               
                filmseansi.seansEkleme(comboFilm.Text, comboSalon.Text, dateTimePicker1.Text, seans);
                MessageBox.Show("Seans Ekleme İşlemi Yapıldı...", "Kayıt");
            }
            else if (seans=="" /*&& comboFilm.Text=="" && comboSalon.Text==""*/)
            {
                MessageBox.Show("Hatalı Seçim Yaptınız...","Uyarı");
            }

            comboFilm.Text = "";
            comboSalon.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
                    
            }
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni == bugün)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                Tarihi_Karşılaştır();     

               
            }
            else if (yeni>bugün)
            {
                Tarihi_Karşılaştır();
            }
            else if (yeni<bugün)
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz...", "UYARI!");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void comboSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();

        }
    }
}
