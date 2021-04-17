using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;

namespace KelimeOyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
           MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);

        public void clear()
        {
            textBox_soru.Clear();
            textBox_kelime.Clear();
           
        }
           
        
        private void button1_Click(object sender, EventArgs e)
        { 
            string cevap = textBox_kelime.Text;
            string ekle;
            if (cevap.Length == 4)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    ekle = "INSERT INTO tbl_dortharf (soru,cevap) " + "VALUES ('" + textBox_soru.Text + "','" + textBox_kelime.Text + "')";

                    MySqlCommand komut = new MySqlCommand(ekle, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ekleme İşlemi Gerçekleşti.");
                    clear();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }

            }
            else if (cevap.Length == 5)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    ekle = "INSERT INTO tbl_besharf (soru,cevap) " + "VALUES ('" + textBox_soru.Text + "','" + textBox_kelime.Text + "')";

                    MySqlCommand komut = new MySqlCommand(ekle, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ekleme İşlemi Gerçekleşti.");
                    clear();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else if (cevap.Length == 6)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    ekle = "INSERT INTO tbl_altiharf (soru,cevap) " + "VALUES ('" + textBox_soru.Text + "','" + textBox_kelime.Text + "')";

                    MySqlCommand komut = new MySqlCommand(ekle, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ekleme İşlemi Gerçekleşti.");
                    clear();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else if (cevap.Length == 7)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    ekle = "INSERT INTO tbl_yediharf (soru,cevap) " + "VALUES ('" + textBox_soru.Text + "','" + textBox_kelime.Text + "')";

                    MySqlCommand komut = new MySqlCommand(ekle, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ekleme İşlemi Gerçekleşti.");
                    clear();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else if (cevap.Length == 8)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    ekle = "INSERT INTO tbl_sekizharf (soru,cevap) " + "VALUES ('" + textBox_soru.Text + "','" + textBox_kelime.Text + "')";

                    MySqlCommand komut = new MySqlCommand(ekle, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ekleme İşlemi Gerçekleşti.");
                    clear();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else if (cevap.Length == 9)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    ekle = "INSERT INTO tbl_dokuzharf (soru,cevap) " + "VALUES ('" + textBox_soru.Text + "','" + textBox_kelime.Text + "')";

                    MySqlCommand komut = new MySqlCommand(ekle, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ekleme İşlemi Gerçekleşti.");
                    clear();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else if (cevap.Length == 10)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();


                    ekle = "INSERT INTO tbl_onharf (soru,cevap) " + "VALUES ('" + textBox_soru.Text + "','" + textBox_kelime.Text + "')";

                    MySqlCommand komut = new MySqlCommand(ekle, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ekleme İşlemi Gerçekleşti.");
                    clear();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else 
            {
                MessageBox.Show("Ekleme hatası!!!");
            }







        }

        private SqlCommand newSqlCommand(string kayit, MySqlConnection baglanti)
        {
            throw new NotImplementedException();
        }

        private void textBox_kelime_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_kelime.Text = textBox_kelime.Text.ToUpper();
            textBox_kelime.SelectionStart = textBox_kelime.Text.Length;
        }

        private void textBox_kelime_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
