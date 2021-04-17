using System;
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
using System.IO;

namespace KelimeOyunu
{
    public partial class Form1 : Form
    {

        public static string sqlbaglanti = "Database=kelimeoyunu; Data Source = localhost; User ID = root; Password =1234;";
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);

        // sqlbaglanti değişkenimizi public static string olarak tanımladım. Çünkü her form için ayrı kod yazmaktansa form1 de bu kodu yazıp diğerlerinde sadece ikinci satırı yazarak bağlantı kurmak daha kolay…

        
        string cevap;
        int sayac = 0;
        int puantoplam = 0;
        int kalandakika=4;
        int kalansaniye = 60;
        int sorucevaplamasuresi = 20;
        dortHarf dortHarf = new dortHarf();
        besHarf besHarf = new besHarf();
        altiHarf altiHarf = new altiHarf();
        yediHarf yediHarf = new yediHarf();
        sekizHarf sekizHarf = new sekizHarf();
        dokuzHarf dokuzHarf = new dokuzHarf();
        onHarf onHarf = new onHarf();
        public Form1()
        {// Formun başına aşağıdaki kodu ekliyoruz..

            MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);

            // Ardından Veri gösterme komutumuzu kendimize göre düzenliyoruz.
            InitializeComponent();
            //con = new MySqlConnection("Server=localhost;Database=kelimeoyunu;user=root;Pwd=1234;SslMode=none");
            birinci.Hide();
            ikinci.Hide();
            ucuncu.Hide();
            dorduncu.Hide();
            besinci.Hide();
            altinci.Hide();
            yedinci.Hide();
            sekizinci.Hide();
            dokuzuncu.Hide();
            onuncu.Hide();
            label10.Hide();
            label7.Text = DateTime.Now.ToLongDateString();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer4.Start();
           

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
           
            birinci.Show();
            ikinci.Show();
            ucuncu.Show();
            dorduncu.Show();
        
            timer1.Start();
            timer2.Start();
            sayac =sayac+1;
            yeniSoru();
            btn_start.Hide();
        }
        public bool Kontrol(ArrayList dizi1, ArrayList dizi2)
        {
            for(int index = 0; index < cevap.Length; index++)
            {
              
                if(dizi1[index].ToString() == dizi2[index].ToString())
                {
                   
                }
                else
                {
                    return false;

                }
            }
            return true;
        }

        public void yeniSoru() 
        {  if (sayac == 1)
            {
                toplampuan.Text = "0";
                sorupuan.Text = "400";
                dortHarf.baglan();
                label4.Text = dortHarf.soru;
                cevap = dortHarf.cevap;
            }
            else if (sayac == 2)
            {
                sorupuan.Text = "400";
                dortHarf.baglan();
                label4.Text = dortHarf.soru;
                cevap = dortHarf.cevap;
            }
            else if (sayac == 3)
            {
                sorupuan.Text = "500";
                besHarf.baglan();
                besinci.Show();
                label4.Text = besHarf.soru;
                cevap = besHarf.cevap;
            }
            else if (sayac == 4)
            {
                sorupuan.Text = "500";
                besHarf.baglan();
                besinci.Show();
                label4.Text = besHarf.soru;
                cevap = besHarf.cevap;
            }
            else if (sayac == 5)
            {
                sorupuan.Text = "600";
                altiHarf.baglan();
                altinci.Show();
                label4.Text = altiHarf.soru;
                cevap = altiHarf.cevap;
            }
            else if (sayac == 6)
            {
                sorupuan.Text = "600";
                altiHarf.baglan();
                altinci.Show();
                label4.Text = altiHarf.soru;
                cevap = altiHarf.cevap;
            }
            else if (sayac == 7)
            {
                sorupuan.Text = "700";
                yediHarf.baglan();
                yedinci.Show();
                label4.Text = yediHarf.soru;
                cevap = yediHarf.cevap;
            }
            else if (sayac == 8)
            {
                sorupuan.Text = "700";
                yediHarf.baglan();
                yedinci.Show();
                label4.Text = yediHarf.soru;
                cevap = yediHarf.cevap;
            }
            else if (sayac == 9)
            {
                sorupuan.Text = "800";
                sekizHarf.baglan();
                sekizinci.Show();
                label4.Text = sekizHarf.soru;
                cevap = sekizHarf.cevap;
            }
            else if (sayac == 10)
            {
                sorupuan.Text = "800";
                sekizHarf.baglan();
                sekizinci.Show();
                label4.Text = sekizHarf.soru;
                cevap = sekizHarf.cevap;
            }
            else if (sayac == 11)
            {
                sorupuan.Text = "900";
                dokuzHarf.baglan();
                dokuzuncu.Show();
                label4.Text = dokuzHarf.soru;
                cevap = dokuzHarf.cevap;
            }
            else if (sayac == 12)
            {
                sorupuan.Text = "900";
                dokuzHarf.baglan();
                dokuzuncu.Show();
                label4.Text = dokuzHarf.soru;
                cevap = dokuzHarf.cevap;
            }
            else if (sayac == 13)
            {
                sorupuan.Text = "1000";
                onHarf.baglan();
                onuncu.Show();
                label4.Text = onHarf.soru;
                cevap = onHarf.cevap;
            }
            else if (sayac == 14)
            {
                sorupuan.Text = "1000";
                onHarf.baglan();
                onuncu.Show();
                label4.Text = onHarf.soru;
                cevap = onHarf.cevap;
            }

            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Oyun BİTTİ");
             
            }

        }

     


        private void butonharfal_Click(object sender, EventArgs e)
        {
         
            Random Rastgele = new Random();
            ArrayList cevapdizi = new ArrayList();

            for (int i = 0; i < cevap.Length; i++)
            {
                cevapdizi.Add(cevap[i]);
            }

            int b = Rastgele.Next(0, cevap.Length);
            string harf = cevapdizi[b].ToString();



            if (b == 0)
            {
                birinci.Text = harf;

            }
            else if (b == 1)
            {
                ikinci.Text = harf;
            }
            else if (b == 2)
            {
                ucuncu.Text = harf;
            }
            else if (b == 3)
            {
                dorduncu.Text = harf;
            }
            else if (b == 4)
            {
                besinci.Text = harf;
            }
            else if (b == 5)
            {
                altinci.Text = harf;
            }
            else if (b == 6)
            {
                yedinci.Text = harf;
            }
            else if (b == 7)
            {
                sekizinci.Text = harf;
            }
            else if (b == 8)
            {
                dokuzuncu.Text = harf;
            }
            else if (b == 9)
            {
                onuncu.Text = harf;
            }
            int puan = Convert.ToInt32(sorupuan.Text);
            puan -= 100;
            sorupuan.Text = puan.ToString();

        }
        public void Temizle()
        {
            birinci.Clear();
            ikinci.Clear();
            ucuncu.Clear();
            dorduncu.Clear();
            besinci.Clear();
            altinci.Clear();
            yedinci.Clear();
            sekizinci.Clear();
            dokuzuncu.Clear();
            onuncu.Clear();
            label4.Text = null;
  
        }
        public static void dosyayaYaz()
        { //kaynak : https://www.kodlamamerkezi.com/c-net/c-ile-dosya-okuma-ve-yazma-islemleri/
            Form1 frm = new Form1();
         
            string dosya_yolu = @"C:\Users\uysal\Desktop\kelimeoyunu.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine("Toplam Puanınız :" + frm.toplampuan  + "" + "Kalan Süreniz : " + frm.kalandakika + ":" + frm.kalansaniye + "" + "Oyun Tarih ve Saati : " + frm.label7.Text + "" + frm.label8.Text);

            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }
        private void cevapla_Click(object sender, EventArgs e)
        {
           
            timer3.Stop();
            label10.Hide();
            yanıtlamasuresi.Hide();
            ArrayList girilencevap = new ArrayList();
            girilencevap.Add(birinci.Text);
            girilencevap.Add(ikinci.Text);
            girilencevap.Add(ucuncu.Text);
            girilencevap.Add(dorduncu.Text);
            girilencevap.Add(besinci.Text);
            girilencevap.Add(altinci.Text);
            girilencevap.Add(yedinci.Text);
            girilencevap.Add(sekizinci.Text);
            girilencevap.Add(dokuzuncu.Text);
            girilencevap.Add(onuncu.Text);

           ArrayList cevapdizi = new ArrayList();



            for (int i = 0; i < cevap.Length; i++)
            {
                cevapdizi.Add(cevap[i]);
            }


            if (Kontrol(girilencevap, cevapdizi) == true)
            {

                MessageBox.Show("doğru");
                Temizle();
                toplamPuanHesapla();

                if (sayac < 15)
                {
                    sayac = sayac + 1;
                    yeniSoru();
                }
                else
                {
                    MessageBox.Show("hatalııııı");
                }
                timer1.Enabled = true;
                timer2.Enabled = true;


            }
            else 
            {
                MessageBox.Show("Yanıt yanlış");
              
            }
            if (sayac == 15) 
            {

                
                MessageBox.Show("Toplam Puanınız :"+toplampuan.Text+""+"Kalan Süreniz : "+kalandakika+":"+kalansaniye+""+ "Oyun Tarih ve Saati : "+label7.Text+""+label8.Text);
             
                dosyayaYaz();
            }
        




        }

       
        public void toplamPuanHesapla()
        {
            
            int puan = Convert.ToInt32(sorupuan.Text);
            puantoplam += puan;

            toplampuan.Text = puantoplam.ToString();
        }
       



        private void label1_Click(object sender, EventArgs e)
        {

        }

    

     

        private void butonsuredurdur_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            timer2.Enabled = false;
             
            timer3.Start();
           
            
     
        }
       



        private void soru_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
          

        }

        private void lblSaniye_Click(object sender, EventArgs e)
        {

        }

        private void birinci_TextChanged(object sender, EventArgs e)
        {
            //girilen değerin sadece büyük harf olmasını ve Türkçe karakterlerde de sorun yaşamamak için internetten 
            //aldığım hazır kodu tüm texboxlar için uyguladım.
            //kaynak:https://www.yazilimkodlama.com/programlama/c-textbox-sadece-buyuk-harf-ya-da-sadece-kucuk-harf-yazdirma/
            birinci.Text = birinci.Text.ToUpper();
            birinci.SelectionStart = birinci.Text.Length;
        }
        private void birinci_KeyPress(object sender, KeyPressEventArgs e)
        {   // textboxların properties kısmından keypress özelliğini aktifleştirdim.
            //girilen değerin sadece harf olmasını rakamları kabul etmemesi için kullandığım kod.Tüm textboxlar için uyguladım
            //kaynak:https://www.youtube.com/watch?v=6Qw73qDj8VQ
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            //girilen değerin özel karakterler içermesini engellemek için kullanılan kod.Tüm textboxlar için uyguladım
            //kaynak:https://mustafabukulmez.com/2018/11/28/c-textbox-sadece-sayi_harf-girisi-yaptirmak/
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void ikinci_TextChanged(object sender, EventArgs e)
        {
            ikinci.Text = ikinci.Text.ToUpper();
            ikinci.SelectionStart = ikinci.Text.Length;
        }
        private void ikinci_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }


        }
        private void ucuncu_TextChanged(object sender, EventArgs e)
        {
            ucuncu.Text = ucuncu.Text.ToUpper();
            ucuncu.SelectionStart = ucuncu.Text.Length;
        }
        private void ucuncu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
        private void dorduncu_TextChanged(object sender, EventArgs e)
        {
            dorduncu.Text = dorduncu.Text.ToUpper();
            dorduncu.SelectionStart = dorduncu.Text.Length;
        }
        private void dorduncu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
        private void besinci_TextChanged(object sender, EventArgs e)
        {
            besinci.Text = besinci.Text.ToUpper();
            besinci.SelectionStart = besinci.Text.Length;
        }
        private void besinci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
        private void altinci_TextChanged(object sender, EventArgs e)
        {
            altinci.Text = altinci.Text.ToUpper();
            altinci.SelectionStart = altinci.Text.Length;
        }
        private void altinci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
        private void yedinci_TextChanged(object sender, EventArgs e)
        {
            yedinci.Text = yedinci.Text.ToUpper();
            yedinci.SelectionStart = yedinci.Text.Length;
        }
        private void yedinci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }

        }

        private void sekizinci_TextChanged(object sender, EventArgs e)
        {
            sekizinci.Text = sekizinci.Text.ToUpper();
            sekizinci.SelectionStart = sekizinci.Text.Length;
        }
        private void sekizinci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }

        }

        private void dokuzuncu_TextChanged(object sender, EventArgs e)
        {
            dokuzuncu.Text = dokuzuncu.Text.ToUpper();
            dokuzuncu.SelectionStart = dokuzuncu.Text.Length;
        }
        private void dokuzuncu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }

        }
        private void onuncu_TextChanged(object sender, EventArgs e)
        {
            onuncu.Text = onuncu.Text.ToUpper();
            onuncu.SelectionStart = onuncu.Text.Length;
        }
        private void onuncu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            
            timer1.Enabled = true;
            timer1.Interval = 1000 * 60 ;

            kalandakika--; //timer her saniyede sayıyı 1 azaltacak
            lblDakika.Text = kalandakika.ToString();
            if (kalandakika == 0)
            {
                timer1.Enabled = false;
            }

        }

       
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 1000;

            if (kalansaniye > 0) {
                kalansaniye--;
                if (kalansaniye == 0)
                {
                    kalansaniye = 60;
                    kalansaniye--;
                }
            }
           

           // kalansaniye--; //timer her saniyede sayıyı 1 azaltacak
            lblSaniye.Text = kalansaniye.ToString();
            /*if (kalansaniye == 0)
            {
                timer2.Enabled = false;
            }*/

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Interval = 1000;
            label10.Show();
        
            if (sorucevaplamasuresi > 0)
            {
                sorucevaplamasuresi--;
                yanıtlamasuresi.Text = sorucevaplamasuresi.ToString();
                if (sorucevaplamasuresi == 0)
                {
                    MessageBox.Show("Yanıtlama süreniz doldu.Doğru cevap:"+cevap);
                  
                    int puan = Convert.ToInt32(sorupuan.Text);
                    puantoplam -= puan;

                    toplampuan.Text = puantoplam.ToString();
                }

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongTimeString();
        }



        
    }
}
