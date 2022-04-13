using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KİM_BİLİR
{
    public partial class YarısmaEkranı : Form
    {
        public YarısmaEkranı()
        {
            InitializeComponent();
        }

        #region SQL Bağlantı
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-ICU6LR7;Initial Catalog=KimBilir;Integrated Security=True");
        #endregion

        #region Çıkış(x) ve Geri(>) Butonları

        private void Geribtn_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }
        private void xbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        int sayac = 0;
        int puan = 0;

        #region Süre Ekranı

        private void YarısmaEkranı_Load(object sender, EventArgs e)
        {
            timerlbl.Text = "10";
            timer1.Interval = 100;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; //1 saniye
            saniye = saniye - 1;
            timerlbl.Text = saniye.ToString();
            if (saniye == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz sona erdi");
            }
        }
        
        int saniye = 60;
        #endregion

        #region Yarışma Başlangıç
        private void baslabtn_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = KİM_BİLİR.Properties.Resources.ArkaPlan1; // Tekrar Eski arkaplanını alsın...
            button2.BackgroundImage = KİM_BİLİR.Properties.Resources.ArkaPlan1;
            button3.BackgroundImage = KİM_BİLİR.Properties.Resources.ArkaPlan1;
            button4.BackgroundImage = KİM_BİLİR.Properties.Resources.ArkaPlan1;
            KalanSürelbl.Visible = true;
            timerlbl.Visible = true;

            timerlbl.Text = "10"; // 10 Saniye Süre
            timer1.Start();
            saniye = Convert.ToInt32(timerlbl.Text);

            baslabtn.Text = "Sonraki Soru";
            sayac++;

            #region Sorular

            if (sayac < 5)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select * from KolaySorular order by NEWID()", baglantı); // order by NEWID()   farklı farklı sorular için
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString()); // KolaySoular tablosundaki a şıkkını button1 e yazdırdık.
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    Sorutxt.Text = (oku["Soru"].ToString());
                    Dogrulbl.Text = (oku["DogruCevap"].ToString()); // Doğru cevabı doğrulblye yazdırdık ki karşılaştırma yapalım...
                }
                baglantı.Close();
            }

            else if (sayac > 5 || sayac < 10)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select * from OrtaSorular order by NEWID()", baglantı); // order by NEWID()   farklı farklı sorular için
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString()); 
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    Sorutxt.Text = (oku["Soru"].ToString());
                    Dogrulbl.Text = (oku["DogruCevap"].ToString());
                }
                baglantı.Close();
            }

            else if (sayac > 10 || sayac < 16)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select * from ZorSorular order by NEWID()", baglantı); // order by NEWID()   farklı farklı sorular için
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString()); 
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    Sorutxt.Text = (oku["Soru"].ToString());
                    Dogrulbl.Text = (oku["DogruCevap"].ToString()); 
                }
                MessageBox.Show("Yarışma bitmiştir TEBRİKLER");
                baglantı.Close();
            }
            #endregion

            #region Puan Hesaplama

            if (puan < 500)
            {
                kazandılbl.Visible = true; // Lbl nin ismi yanlış olacak 
                //kaybettilbl.Visible = false;
                Kazandıbtn.Visible = false;
            }
            else if (puan >= 500)
            {
                Kazandıbtn.Visible = true;
                //kaybettilbl.Visible = true;
                kazandılbl.Visible = false; // Lbl nin ismi yanlış olacak 
                Çıkışbtn.Visible = false;
            }

            #endregion

        }
        #endregion

        #region Şıklar
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == Dogrulbl.Text)
            {
                button1.BackgroundImage = null;
                button1.BackColor = Color.Lime;
                timer1.Stop();
                puan += 100;
                Puanlbl.Text = puan.ToString();
                PuanBilgilendirmelbl.Text = puan.ToString();
                Doğrulbl.Text = Convert.ToString(sayac);
            }
            else
            {
                button1.BackgroundImage = null;
                button1.BackColor = Color.Red;
                timer1.Stop();
                MessageBox.Show("Üzgünüz yanlış cevap.");
                panel1.Visible = true;
                baslabtn.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == Dogrulbl.Text)
            {
                button2.BackgroundImage = null;
                button2.BackColor = Color.Lime;
                timer1.Stop();
                puan += 100;
                Puanlbl.Text = puan.ToString();
                PuanBilgilendirmelbl.Text = puan.ToString();
                Doğrulbl.Text = Convert.ToString(sayac);
            }
            else
            {
                button2.BackgroundImage = null;
                button2.BackColor = Color.Red;
                timer1.Stop();
                MessageBox.Show("Üzgünüz yanlış cevap.");
                panel1.Visible = true;
                baslabtn.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == Dogrulbl.Text)
            {
                button3.BackgroundImage = null;
                button3.BackColor = Color.Lime;
                timer1.Stop();
                puan += 100;
                Puanlbl.Text = puan.ToString();
                PuanBilgilendirmelbl.Text = puan.ToString();
                Doğrulbl.Text = Convert.ToString(sayac);
            }
            else
            {
                button3.BackgroundImage = null;
                button3.BackColor = Color.Red;
                timer1.Stop();
                MessageBox.Show("Üzgünüz yanlış cevap.");
                panel1.Visible = true;
                baslabtn.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == Dogrulbl.Text)
            {
                button4.BackgroundImage = null;
                button4.BackColor = Color.Lime;
                timer1.Stop();
                puan += 100;
                Puanlbl.Text = puan.ToString();
                PuanBilgilendirmelbl.Text = puan.ToString();
                Doğrulbl.Text = Convert.ToString(sayac);
            }
            else
            {
                button4.BackgroundImage = null;
                button4.BackColor = Color.Red;
                timer1.Stop();
                MessageBox.Show("Üzgünüz yanlış cevap.");
                panel1.Visible = true;
                baslabtn.Visible = false;
            }
        }

        #endregion

        #region Kazandı ve çıkış Butonu

        private void Kazandıbtn_Click(object sender, EventArgs e)
        {
            KuponluGirişÖdül Ödül = new KuponluGirişÖdül();
            Ödül.Show();
            this.Hide();
        }
        private void Çıkışbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
