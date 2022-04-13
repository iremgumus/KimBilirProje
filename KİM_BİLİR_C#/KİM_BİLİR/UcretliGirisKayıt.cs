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
using Dapper;

namespace KİM_BİLİR
{
    public partial class UcretliGirisKayıt : Form
    {
        public UcretliGirisKayıt()
        {
            InitializeComponent();
        }

      

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

        private void KayıtOlbtn_Click(object sender, EventArgs e)
        {
            KayıtOl kayıt = new KayıtOl();
            kayıt.Show();
            this.Hide();
        }

        KullanıcıGirisi k = new KullanıcıGirisi();
        PersonelGiris p = new PersonelGiris();
        private void Grisbtn_Click(object sender, EventArgs e)
        {
            k.KulllanıcıKontrol(Adıtxt, Soyadıtxt, Sıfretxt);
            p.PersonelKontrol(Adıtxt, Soyadıtxt, Sıfretxt);

        }


        private void UcretliGirisKayıt_Load(object sender, EventArgs e)
        {
            Adıtxt.Select();
        }

        public class KullanıcıGirisi
        {
            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-ICU6LR7;Initial Catalog=KimBilir;Integrated Security=True");
            SqlCommand komut;
            SqlDataReader read;

            public SqlDataReader KulllanıcıKontrol(TextBox Adı, TextBox Soyadı, TextBox Sıfre)
            {
                baglantı.Open();
                komut = new SqlCommand();
                komut.Connection = baglantı;
                komut.CommandText = "select * from UcretliMusteriKayıt where Adı='" + Adı.Text + "'and Soyadı='" + Soyadı.Text + "'and Sifre='" + Sıfre.Text + "'";
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    MessageBox.Show("HOŞGELDİNİZ");
                    YarısmaEkranıÜcetli yarısma = new YarısmaEkranıÜcetli();
                    yarısma.Show();
                }
                else
                {
                    MessageBox.Show("Bilgiler hatalı lütfen tekrar deneyiniz.");
                }
                baglantı.Close();
                return read;
            }
        }

        public class PersonelGiris
        {
            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-ICU6LR7;Initial Catalog=KimBilir;Integrated Security=True");
            SqlCommand komut;
            SqlDataReader read;

            public SqlDataReader PersonelKontrol(TextBox Adı, TextBox Soyadı, TextBox Sıfre)
            {
                baglantı.Open();
                komut = new SqlCommand();
                komut.Connection = baglantı;
                komut.CommandText = "select * from PersonelGirisBilgileri where Ad='" + Adı.Text + "'and Soyad='" + Soyadı.Text + "'and Sifre='" + Sıfre.Text + "'";
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    MessageBox.Show("HOŞGELDİN PATRON");
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    
                }
                else
                {
                    //MessageBox.Show("Bilgiler hatalı lütfen tekrar deneyiniz.");
                }
                baglantı.Close();
                return read;
            }
        }

        private void Adıtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hem Adıtxt hemde Soyadıtxt için sayı girilemez komutu...
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void Sıfretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayıya izin veriliyor... Şifre ve Telefon için geçerli...
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        void Sifre()
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                Sıfretxt.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                Sıfretxt.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Sifre();
        }
    }
}
