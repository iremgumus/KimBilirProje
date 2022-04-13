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
    public partial class KuponGiris : Form
    {
        public KuponGiris()
        {
            InitializeComponent();
        }

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

        private void flobtn_Click(object sender, EventArgs e)
        {
            FloGiris Flo = new FloGiris();
            Flo.Show();
            this.Hide();
        }

        private void DRbtn_Click(object sender, EventArgs e)
        {
            DRGiris DR = new DRGiris();
            DR.Show();
            this.Hide();
        }

        private void LCWbtn_Click(object sender, EventArgs e)
        {
            LcwGiris LCW = new LcwGiris();
            LCW.Show();
            this.Hide();
        }

        private void defactobtn_Click(object sender, EventArgs e)
        {
            DefactoGiris DEFACTO = new DefactoGiris();
            DEFACTO.Show();
            this.Hide();
        }
        private void MİGROSBtn_Click_1(object sender, EventArgs e)
        {
            MigrosGiris MİGROS = new MigrosGiris();
            MİGROS.Show();
            this.Hide();
        }

        private void mavibtn_Click(object sender, EventArgs e)
        {
            MaviGiris Mavi = new MaviGiris();
            Mavi.Show();
            this.Hide();
        }

        private void flobtn_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
