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
    public partial class FloGiris : Form
    {
        public FloGiris()
        {
            InitializeComponent();
        }

        private void FloGiris_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Flo.mp4";
            axWindowsMediaPlayer1.Dock = DockStyle.Right;
            axWindowsMediaPlayer1.enableContextMenu = false;
            axWindowsMediaPlayer1.Ctlenabled = false;

            kupontxt.Select();
        }

        private void xbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Geribtn_Click(object sender, EventArgs e)
        {
            KuponGiris gerii = new KuponGiris();
            gerii.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (kupontxt.Text == "")
            {
                kupontxt.Text = "Lütfen fişteteki müşteri numarasını giriniz...";

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (kupontxt.Text == "Lütfen fişteteki müşteri numarasını giriniz...")
            {
                kupontxt.Text = "";
                kupontxt.ForeColor = Color.Black;
            }
        }
        KuponluGiris k = new KuponluGiris();

        private void Kuponbtn_Click(object sender, EventArgs e)
        {
            k.KulllanıcıKontrol(kupontxt);
            axWindowsMediaPlayer1.close();
        }
        public class KuponluGiris
        {
            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-ICU6LR7;Initial Catalog=KimBilir;Integrated Security=True");
            SqlCommand komut;
            SqlDataReader read;
            

            public SqlDataReader KulllanıcıKontrol(TextBox KuponKod)
            {
                baglantı.Open();
                komut = new SqlCommand();
                komut.Connection = baglantı;
                komut.CommandText = "select * from Flo where KuponKod='" + KuponKod.Text + "'";
                read = komut.ExecuteReader();
               
                if (read.Read() == true)
                {
                    MessageBox.Show("HOŞGELDİNİZ");
                    YarısmaEkranı yarısma = new YarısmaEkranı();
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
    }
}
