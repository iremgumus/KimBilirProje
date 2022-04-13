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
    public partial class YarısmaEkranıÜcetli : Form
    {
        public YarısmaEkranıÜcetli()
        {
            InitializeComponent();
        }
        #region SQL Bağlantı
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-ICU6LR7;Initial Catalog=KimBilir;Integrated Security=True");
        #endregion

        int sayac = 0;
        int puan = 0;

        #region Süre Ekranı
        private void YarısmaEkranıÜcetli_Load(object sender, EventArgs e)
        {
            timerlbl.Text = "10";
            timer2.Interval = 100;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer2.Interval = 1000; //1 saniye
            saniye = saniye - 1;
            timerlbl.Text = saniye.ToString();
            if (saniye == 0)
            {
                timer2.Stop();
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
            timer2.Start();
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

            else if (sayac > 10)
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
                baglantı.Close();
            }
            #endregion

            #region Puan Hesaplama

            if (puan < 500)
            {
                label4.Visible = true; // Lbl nin ismi yanlış olacak 
                //kaybettilbl.Visible = false;
                Kazandı2btn.Visible = false;
            }
            else if (puan >= 500)
            {
                Kazandı2btn.Visible = true;
                //kaybettilbl.Visible = true;
                label4.Visible = false; // Lbl nin ismi yanlış olacak 
                Çıkış2btn.Visible = false;
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
                timer2.Stop();
                puan += 100;
                Puanlbl.Text = puan.ToString();
                PuanBilgilendirme2lbl.Text = puan.ToString();
                doğru2lbl.Text = Convert.ToString(sayac);
            }
            else
            {
                button1.BackgroundImage = null;
                button1.BackColor = Color.Red;
                timer2.Stop();
                MessageBox.Show("Üzgünüz yanlış cevap.");
                baslabtn.Visible = false;
                panel2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == Dogrulbl.Text)
            {
                button2.BackgroundImage = null;
                button2.BackColor = Color.Lime;
                timer2.Stop();
                puan += 100;
                Puanlbl.Text = puan.ToString();
                PuanBilgilendirme2lbl.Text = puan.ToString();
                doğru2lbl.Text = Convert.ToString(sayac);
            }
            else
            {
                button2.BackgroundImage = null;
                button2.BackColor = Color.Red;
                timer2.Stop();
                MessageBox.Show("Üzgünüz yanlış cevap.");
                baslabtn.Visible = false;
                panel2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == Dogrulbl.Text)
            {
                button3.BackgroundImage = null;
                button3.BackColor = Color.Lime;
                timer2.Stop();
                puan += 100;
                Puanlbl.Text = puan.ToString();
                PuanBilgilendirme2lbl.Text = puan.ToString();
                doğru2lbl.Text = Convert.ToString(sayac);
            }
            else
            {
                button3.BackgroundImage = null;
                button3.BackColor = Color.Red;
                timer2.Stop();
                MessageBox.Show("Üzgünüz yanlış cevap.");
                baslabtn.Visible = false;
                panel2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == Dogrulbl.Text)
            {
                button4.BackgroundImage = null;
                button4.BackColor = Color.Lime;
                timer2.Stop();
                puan += 100;
                Puanlbl.Text = puan.ToString();
                PuanBilgilendirme2lbl.Text = puan.ToString();
                doğru2lbl.Text = Convert.ToString(sayac);
            }
            else
            {
                button4.BackgroundImage = null;
                button4.BackColor = Color.Red;
                timer2.Stop();
                MessageBox.Show("Üzgünüz yanlış cevap.");
                baslabtn.Visible = false;
                panel2.Visible = true;
            }
        }
        #endregion

        #region Kazandı ve çıkış Butonu

        private void Çıkış2btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Kazandı2btn_Click_1(object sender, EventArgs e)
        {
            //ÜcretliGirişÖdül Ödül = new KuponluGirişÖdül();
            //Ödül.Show();
            //this.Hide();
        }
        #endregion
    }
}
