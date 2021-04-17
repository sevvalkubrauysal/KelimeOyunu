using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace KelimeOyunu
{
    public partial class Giris : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Giris()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kelimeoyunu;user=root;Pwd=1234;SslMode=none");
         
        }


        private void Giris_Load(object sender ,EventArgs e)
        {
            

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           
            string user = textBox1.Text;
            string pass = textBox2.Text;
             cmd = new MySqlCommand();
             con.Open();
             cmd.Connection = con;
             cmd.CommandText = "SELECT * FROM tbl_giris where kullanici_adi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
             dr = cmd.ExecuteReader();
             if (dr.Read())
             {
                 MessageBox.Show("Giriş Başarılı.Kelime Oyunu");
                 this.Hide();
                 Home home = new Home();
                 home.Show();
             }
             else
             {
                 MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
             }
             con.Close();


           

        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Giris_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
