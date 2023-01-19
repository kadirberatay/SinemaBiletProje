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
    public partial class filmEkle : Form
    {
        public filmEkle()
        {
            InitializeComponent();
        }

        //    sinemaTableAdapters.filmBilgiTableAdapter film = new sinemaTableAdapters.filmBilgiTableAdapter();
        sinemaTableAdapters.filmBilgiTableAdapter film = new sinemaTableAdapters.filmBilgiTableAdapter();


        private void btnGeri_Click(object sender, EventArgs e)
        {
            adminEkrani gecis = new adminEkrani();
            this.Hide();
            gecis.ShowDialog();
        }


        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            if ( !String.IsNullOrWhiteSpace(txtFilmAdi.Text) || !String.IsNullOrWhiteSpace(txtSure.Text) || !String.IsNullOrWhiteSpace(txtYapimYili.Text) || !String.IsNullOrWhiteSpace(txtYonetmen.Text)) 
            {
                try
                {
                    film.FilmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSure.Text, dateTimePicker1.Text, txtYapimYili.Text, pictureBox1.ImageLocation);
           //         film.filmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSure.Text, dateTimePicker1.Text, txtYapimYili.Text, pictureBox1.ImageLocation);
                    MessageBox.Show("Film Bilgileri Eklendi...", "Kayıt");
                }
                catch (Exception)
                {

                    MessageBox.Show("Bu film daha önce eklenmiştir!!", "UYARI");
                }

                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                comboFilmTuru.Text = "";
            }

            else
            {
                MessageBox.Show("Bos Alan Birakamazsiniz...");
            }

            
           
            


        }

        private void filmEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
