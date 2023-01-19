using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SinemaBiletProje
{
    public partial class adminGiris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public adminGiris()
        {
            InitializeComponent();
        }

        adminEkrani gecis = new adminEkrani();

        private void button1_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-0C2AB06\\SQLEXPRESS;Initial Catalog=SinemaBiletOtomasyondbo;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From adminbilgi where adminLogin='" + textBox1.Text +
                "'And adminPassword='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {   
                MessageBox.Show("Tebrikler, Giriş Başarılı...");
                this.Hide();
                gecis.ShowDialog();
                

            }

            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre...");
            }
            con.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
