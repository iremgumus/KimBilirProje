using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KİM_BİLİR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucretbtn_Click(object sender, EventArgs e)
        {
            UcretliGirisKayıt Ucret = new UcretliGirisKayıt();
            Ucret.Show();
            this.Hide();

          
        }

        private void xbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kuponbtn_Click(object sender, EventArgs e)
        {
            KuponGiris kupon = new KuponGiris();
            kupon.Show();
            this.Hide();
        }
    }
}
