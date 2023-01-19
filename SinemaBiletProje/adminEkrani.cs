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
    public partial class adminEkrani : Form
    {
        public adminEkrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            biletSatisEkrani bse = new biletSatisEkrani();
            this.Hide();
            bse.ShowDialog();
            
        }

        private void adminEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            filmEkle gecis = new filmEkle();
            this.Hide();
            gecis.ShowDialog();
        }
    }
}
