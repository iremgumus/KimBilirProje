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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        // DAPPER SQL BAĞLANTISI ...
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-ICU6LR7;Initial Catalog=KimBilir;Integrated Security=True");

        #region Çıkış(x) ve Geri(>) Butonları
        private void Geribtn_Click(object sender, EventArgs e)
        {
            UcretliGirisKayıt geri = new UcretliGirisKayıt();
            geri.Show();
            this.Hide();
        }

        private void xbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        // SQL Veritabanında KayıtID oluşturabilmemiz için id adında int tanımladık..
        int id = 0;

        private void KayıtOl_Load(object sender, EventArgs e)
        {
            Adıtxt.Select();
        }

        private void KayıtOlbtn_Click(object sender, EventArgs e)
        {
            // Kısıtlama ( SQL'de kayıt yapılabilmesi için gerekliik. )
            if (Adıtxt.Text == "" || Soyadıtxt.Text == "" || Sifretxt.Text == " ")
            {
                MessageBox.Show("Ad, Soyad ve Şifre boş geçilemez!");
            }
            else
            {
                // Dapper ile Sql balantısı kuruldu ve Kayıt için parametreler Textboxlardan alındı. Son olarak MüşteriEkle Stored
                // Procedure ile kayıt oluşturuldu....
                try
                {
                    // Kayıt isminde nesne oluşturduk ve textboxlardan kayıt için bilgileri aldık. 
                    DynamicParameters Kayıt = new DynamicParameters();
                    Kayıt.Add("@KayıtID", id, DbType.Int32, ParameterDirection.Input, ((short)id));
                    Kayıt.Add("@Adı", Adıtxt.Text.Trim());
                    Kayıt.Add("@Soyadı", Soyadıtxt.Text.Trim());
                    Kayıt.Add("@Sifre", Sifretxt.Text.Trim());
                    Kayıt.Add("@Telefon", Telefontxt.Text.Trim());
                    Kayıt.Add("@Eposta", Epostatxt.Text.Trim());
                    sqlCon.Execute
                        ("MusteriEkle", Kayıt, commandType: CommandType.StoredProcedure);

                    MessageBox.Show("Kaydınız Oluşturuldu.");
                    Temizle(); // Textbolar temizlendi.

                    UcretliGirisKayıt giriş = new UcretliGirisKayıt(); // Giriş ekranına yönlendirildi...
                    giriş.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                finally
                {
                    sqlCon.Close();
                }
            } 
        }

        class MusteriKayıt
        {
            public int ID { get; set; }
            public string Adı { get; set; }
            public string Soyadı { get; set; }
            public string Sıfre { get; set; }
            public string Telefon { get; set; }
            public string Eposta { get; set; }
        }

        void Temizle()
        {
            Adıtxt.Clear();
            Soyadıtxt.Clear();
            Sifretxt.Clear();
            Telefontxt.Clear();
            Epostatxt.Clear();
        }

        private void Adıtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hem Adıtxt hemde Soyadıtxt için sayı girilemez komutu...
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void Sifretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayıya izin veriliyor... Şifre ve Telefon için geçerli...
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        void Sifre()
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                Sifretxt.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                Sifretxt.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Sifre();
        }

        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
