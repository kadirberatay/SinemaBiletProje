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
    public partial class biletSatisEkrani : Form
    {
        public biletSatisEkrani()
        {
            InitializeComponent();
        }
        int sayac = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0C2AB06\\SQLEXPRESS;Initial Catalog=SinemaBiletOtomasyondbo;Integrated Security=True");

        private void FilmveSalonGetir(ComboBox combo, string sql1, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())

            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        //private void FilmAfişiGoster()
        //{
        //    baglanti.Open();
        //    SqlCommand komut = new SqlCommand("select * from filmBilgi where filmAdi='" + comboFilmAdi.SelectedItem + "'", baglanti);
        //    SqlDataReader read = komut.ExecuteReader();
        //    while (read.Read())
        //    {
        //        pictureBox1.ImageLocation = read["resim"].ToString();
        //    }
        //    baglanti.Close();
        //}

        private void Combo_Dolu_Koltuklar()
        {
            comboBox5.Items.Clear();
            comboBox5.Text = "";

            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        comboBox5.Items.Add(item.Text);
                    }
                }
            }
        }

        private void YenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Green;   
                }
            }
        }


        private void Veritabani_Dolu_Koltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from satisBilgi where filmAdi='" + comboFilmAdi.SelectedItem + "'and salonAdi='" + comboSalonAdi.Text + "' and tarih='" + comboFilmTarihi.SelectedItem + "'and saat='" + comboFilmSeansi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["koltukNumarasi"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;

                        }
                    }
                }
            }
            baglanti.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Boş_Koltuklar();
            FilmveSalonGetir(comboFilmAdi, "select *from filmBilgi", "filmAdi");
            FilmveSalonGetir(comboSalonAdi, "select *from salonBilgi", "salonAdi");
        }

        private void Boş_Koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                   
                    Button btn = new Button();
                    btn.BackColor = Color.Green;
                    btn.Size = new Size(31, 31);
                    btn.Location = new Point(j * 31 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;


                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (b.BackColor == Color.Green)
            {
                txtKoltukNo.Text = b.Text;
            }
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            filmEkle gecis = new filmEkle();
            this.Hide();
            gecis.ShowDialog();

        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            seansEkleme gecis2 = new seansEkleme();
            this.Hide();
            gecis2.ShowDialog();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            seansListeleme gecis3 = new seansListeleme();
            this.Hide();
            gecis3.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSatisListele_Click(object sender, EventArgs e)
        {
            satisListeleme sts = new satisListeleme();
            this.Hide();
            sts.ShowDialog();
        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFilmSeansi.Items.Clear();
            comboFilmTarihi.Items.Clear();
            comboFilmSeansi.Text = "";
            comboFilmTarihi.Text = "";
            comboSalonAdi.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
           
            //FilmAfişiGoster();
            YenidenRenklendir();
            Combo_Dolu_Koltuklar();
        }

        sinemaTableAdapters.satisBilgiTableAdapter satis = new sinemaTableAdapters.satisBilgiTableAdapter();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text!="")
            {
                try
                {

                    satis.Satış_Yap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarihi.Text, comboFilmSeansi.Text, txtAd.Text, txtSoyad.Text, comboUcret.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklendir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata oluştu..."+hata.Message ,"UYARI!!!");
                }
                
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız...", "UYARI!!!");

            }
        }

        private void Film_Tarihi_Getir()
        {
            comboFilmTarihi.Text = "";
            comboFilmSeansi.Text = "";
            comboFilmTarihi.Items.Clear();
            comboFilmSeansi.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from seansBilgi where filmAdi='" + comboFilmAdi.SelectedItem + "'and salonAdi='" + comboSalonAdi.SelectedItem + "'",baglanti);

            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString())>=DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboFilmTarihi.Items.Contains(read["tarih"].ToString()))
                    {
                        comboFilmTarihi.Items.Add(read["tarih"].ToString());

                    }
                }

            }
            baglanti.Close();
        
        }
        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();
        }

        private void Film_Seansi_Getir()
        {
            comboFilmSeansi.Text = "";
            comboFilmSeansi.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from seansBilgi where filmAdi='" + comboFilmAdi.SelectedItem + "'and salonAdi='" + comboSalonAdi.SelectedItem + "' and tarih='"+comboFilmTarihi.SelectedItem+"'", baglanti);

            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(read["seans"].ToString())>DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        comboFilmSeansi.Items.Add(read["seans"].ToString());

                    }


                }
          else      if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))

                {
                    
                        comboFilmSeansi.Items.Add(read["seans"].ToString());

                    
                }

            }
            baglanti.Close();


        }
        private void comboFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seansi_Getir();
        }

        private void comboFilmSeansi_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            Veritabani_Dolu_Koltuklar();
            Combo_Dolu_Koltuklar();

        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text != "")
            {

                try
            {
                    satis.Satış_İptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarihi.Text, comboFilmSeansi.Text, comboBox5.Text);
                    YenidenRenklendir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
            catch (Exception hata)
            {

                    MessageBox.Show("Hata oluştu!!!"+hata.Message,"UYARI");
                }
            }
            
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!!!","UYARI!!!");
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            girisEkrani gecis = new girisEkrani();
            this.Hide();
            gecis.ShowDialog();
        }
    }
}
