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
    public partial class girisEkrani : Form
    {

        

        public girisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            adminGiris adm = new adminGiris();
            adm.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            personelGiris prs = new personelGiris();
            prs.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
