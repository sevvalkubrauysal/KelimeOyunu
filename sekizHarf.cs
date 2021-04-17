using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;


namespace KelimeOyunu
{
    class sekizHarf
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        public string soru { get; set; }
        public string cevap { get; set; }

        public int boyut { get; set; }
        public void baglan()
        {

            baglanti.Open();
            Random rnd = new Random();
            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM tbl_sekizharf", baglanti);
            boyut = Convert.ToInt32(komut.ExecuteScalar());
            // random sayı ürettik.parantez içindeki ilk sayı dahil ikincisi dahil değil olarak sayı üreteceği için boyutun 1 fazlasını
            //aldım ki son satırda gelebilsin.
            int r = rnd.Next(1, boyut + 1);
            MySqlCommand cmd = new MySqlCommand("select * from tbl_sekizharf where Id = '" + r + "'", baglanti);

            int Count = Convert.ToInt32(cmd.ExecuteScalar());

            if (Count != 0)
            {

                MySqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {

                    soru = oku["soru"].ToString();


                    cevap = oku["cevap"].ToString();

                }

            }

            baglanti.Close();

        }
    }
}
