using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace KİM_BİLİR
{
    public partial class AdminForm : Form
    {
     SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-ICU6LR7;Initial Catalog=KimBilirgüncel;Integrated Security=True");
      


        int id = 0;
        int idd = 0;

        public AdminForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
         

        }
        private void arabtn_Click(object sender, EventArgs e)
        {
            #region PersonelDetayTablosu
            try
            {
                PersonelDetayTablosu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                UcretliuPuanTablosuu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                AVMTablo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                MuhasebeTablo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                KolaySoruTablo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                OrtaSoruTablo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            #endregion
            #region PersonleGrişTablosu
            try
            {
                PersonelGrisTablosu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            #region KazanılanKuponBilgisi
            try
            {
                KazanılanKuponBilgisii();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            #endregion
            #region KazanılanKuponBilgisi
            try
            {
                KuponluPuanTablosuu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                FloTablo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                MigrosTablo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                LCWTablo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                MaviTablo();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                DefactoTablo();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                DRTablo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                FloReklamTablo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                MigrosReklamTablo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                LCWReklamTablo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                MaviReklamTablo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                DRReklamTablo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                DefactoReklamTablo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }


            #endregion

            #endregion

        }

        #region Butongeçiş kodu
        private void customizeDesign()
        {
            panelkuponlu.Visible = false;
            panelmagazalar.Visible = false;
            panelmagazareklam.Visible = false;
            panelpersonel.Visible = false;
            panelsorular.Visible = false;
            panelücretli.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelkuponlu.Visible == true)
            {
                panelkuponlu.Visible = false;
            }
            if (panelmagazalar.Visible == true)
            {
                panelmagazalar.Visible = false;
            }
            if (panelmagazareklam.Visible == true)
            {
                panelmagazareklam.Visible = false;
            }
            if (panelpersonel.Visible == true)
            {
                panelpersonel.Visible = false;
            }
            if (panelsorular.Visible == true)
            {
                panelsorular.Visible = false;
            }
            if (panelücretli.Visible == true)
            {
                panelücretli.Visible = false;
            }
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region MENÜ
        private void personelbtn_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelpersonel);
        }
        private void ücretlimüşteribtn_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelücretli);
        }
        private void kuponlumüşteribtn_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelkuponlu);
        }
        private void magazabtn_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelmagazalar);
        }
        private void reklambtn_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(panelmagazareklam);

        }
        private void Sorularbtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelsorular);
        }


        //private void Sorularbtn_Click_1(object sender, EventArgs e)
        //{
        //    ShowSubMenu(panelsorular);
        //}
        #endregion

        #region x ve > butonları
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

        #region TABLOLAR


        #region Personel Detay Tablosu
        private void Personeldetaybtn_Click(object sender, EventArgs e)
        {
            // Sifretxt.PasswordChar.ToString("*");
            personelgirişbtn.Enabled = true;
            Personeldetaybtn.Enabled = false;
            flobtn.Enabled = true;


            Sifrelbl.Text = "Adres";
            Adılbl.Text = "Adı";
            Soyadılbl.Text = "Soyadı";
            Telefonlbl.Text = "Telefon";
            Epostalbl.Text = "E Posta";

            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;

            #region PersonelDetayTablosu
            try
            {


                PersonelDetayTablosu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            #endregion


        }
        void PersonelDetayTablosu()
        {

            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<PersonelDetay> list = sqlCon.Query<PersonelDetay>
                ("PersonelArama", param, commandType: CommandType.StoredProcedure).ToList<PersonelDetay>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            // dataGridView1.Columns[6].Visible = false;
        }
      public class PersonelDetay
        {
            public int PersonelDId { get; set; }

            public string Adı { get; set; }
            public string soyadı { get; set; }

            public string Telefon { get; set; }

            public string Adresi { get; set; }
            public string Email { get; set; }



        }
        #endregion

        #region Personel Giriş Tablosu
        private void personelgirişbtn_Click(object sender, EventArgs e)
        {

            personelgirişbtn.Enabled = false;
            Personeldetaybtn.Enabled = true;
            flobtn.Enabled = true;
            //  Personeldetaybtn.Enabled = false;


            Sifrelbl.Text = "Şifre";
            Adılbl.Text = "Adı";
            Soyadılbl.Text = "Soyadı";
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            try
            {

                PersonelGrisTablosu();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void PersonelGrisTablosu()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<PersonelGirisBilgileri> list = sqlCon.Query<PersonelGirisBilgileri>
                ("PersonelGiris", param, commandType: CommandType.StoredProcedure).ToList<PersonelGirisBilgileri>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            // dataGridView1.Columns[4].Visible = false;
        }
        public class PersonelGirisBilgileri
        {
            public int PersonelId { get; set; }

            public string Ad { get; set; }
            public string Soyad { get; set; }

            public string Sifre { get; set; }

        }


        void Clear()
        {
            Adıtxt.Clear();
            Soyadıtxt.Clear();
            Sifretxt.Clear();
            Telefontxt.Clear();
            Epostatxt.Clear();
           // throw new NotImplementedException();
        }










        #endregion

        #region Ücretli Puan Tablosu
        private void ücretlipuanbtn_Click(object sender, EventArgs e)
        {
           

            Soyadılbl.Text = "Yanlış Cevap";
            Adılbl.Text = "Doğru Cevap";
            Sifrelbl.Text = "Puan";
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adıtxt.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            try
            {

                UcretliuPuanTablosuu();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void UcretliuPuanTablosuu()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<UcretliuPuanTablosu> list = sqlCon.Query<UcretliuPuanTablosu >
                ("UcretliPuanAramaa", param, commandType: CommandType.StoredProcedure).ToList<UcretliuPuanTablosu>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
             dataGridView1.Columns[4].Visible = false;
        }
        class UcretliuPuanTablosu
        {
            public int UcretliPId { get; set; }

            public int DoğruCevap { get; set; }
            public int YanlışCevap { get; set; }
            public int Puan { get; set; }
            public int ID { get; set; }




        }


        #endregion

        #region Kazanılan Kupon Bilgisi Tablosu

        private void kazanılanbtn_Click(object sender, EventArgs e)
        {
            Adılbl.Text = "Adı";
            Soyadılbl.Text = "Soyadı";
            Sifrelbl.Text = "Mağaza Adı ";
            Telefonlbl.Text = "Kupon Kodu";
          

            Adılbl.Visible = true;
            Adıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Soyadıtxt.Visible = true;          
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;

            try
            {

                KazanılanKuponBilgisii();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void KazanılanKuponBilgisii()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<KazanılanKuponBilgisi> list = sqlCon.Query<KazanılanKuponBilgisi>
                ("KazanılanKuponBilgisiArama", param, commandType: CommandType.StoredProcedure).ToList<KazanılanKuponBilgisi>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
             dataGridView1.Columns[5].Visible = false;
        }
        class KazanılanKuponBilgisi
        {
            public int KazanılanKId { get; set; }

            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string KuponMagaza { get; set; }
            public string KuponKod { get; set; }
            public int KuponluYId { get; set; }

        }
        //void Clear()
        //{
        //    //Adıtxt.Clear();
        //    //Soyadıtxt.Clear();
        //    //Sifretxt.Clear();
        //    //Telefontxt.Clear();
        //    //Epostatxt.Clear();
        //    //throw new NotImplementedException();
        //}

        #endregion

        #region KuponluPuanTablosu
        private void kuponlupuanbtn_Click(object sender, EventArgs e)
        {
            Soyadılbl.Text = "Yanlış Cevap";
            Adılbl.Text = "Doğru Cevap";
  
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adıtxt.Visible = true;
            Sifrelbl.Visible = false;
            Sifretxt.Visible = false;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;




            try
            {

                KuponluPuanTablosuu();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void KuponluPuanTablosuu()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<KuponluPuanTablosu> list = sqlCon.Query<KuponluPuanTablosu>
                ("KuponluPuanlarTablosu", param, commandType: CommandType.StoredProcedure).ToList<KuponluPuanTablosu>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            // dataGridView1.Columns[4].Visible = false;
        }
        class KuponluPuanTablosu
        {
            public int MusteriId { get; set; }

            public string DogruCevap { get; set; }
            public string YanlısCevap { get; set; }
            

        }

        #endregion

        #region Flo
        private void flobtn_Click(object sender, EventArgs e)
        {
            personelgirişbtn.Enabled = true;
            Personeldetaybtn.Enabled = true;
            flobtn.Enabled = false;

            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;

            Adılbl.Text ="Yerkili Adı";
            Soyadılbl.Text = "Yerkili Telefon";
            Sifrelbl.Text = "Avm Adres";
            Telefonlbl.Text = "GEnel Müdürlük";
            Epostalbl.Text = "Kupon Kodu";

            try
            {

                FloTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void FloTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<Flo> list = sqlCon.Query<Flo>
                ("FloArama", param, commandType: CommandType.StoredProcedure).ToList<Flo>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
             dataGridView1.Columns[5].Visible = false;
        }
        class Flo
        {
            public int MagazaId { get; set; }

            public string YetkiliAd { get; set; }
            public string YetkiliTelefon { get; set; }

            public string AvmAdres { get; set; }

            public string GenelMüdürlük { get; set; }
            public int AvmId { get; set; }

            public string KuponKod { get; set; }



        }

        #endregion

        #region Migros
        private void migrosbtn_Click(object sender, EventArgs e)
        {

            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;

            Adılbl.Text = "Yerkili Adı";
            Soyadılbl.Text = "Yerkili Telefon";
            Sifrelbl.Text = "Avm Adres";
            Telefonlbl.Text = "GEnel Müdürlük";
            Epostalbl.Text = "Kupon Kodu";
            try
            {

                MigrosTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void MigrosTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<Migros> list = sqlCon.Query<Migros>
                (" MigrosArama", param, commandType: CommandType.StoredProcedure).ToList<Migros>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        class Migros
        {
            public int MagazaId { get; set; }

            public string YetkiliAd { get; set; }
            public string YetkiliTelefon { get; set; }

            public string AvmAdres { get; set; }

            public string GenelMüdürlük { get; set; }
            public int AvmId { get; set; }

            public string KuponKod { get; set; }



        }

        #endregion

        #region LCW
        private void LCWbtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;

            Adılbl.Text = "Yerkili Adı";
            Soyadılbl.Text = "Yerkili Telefon";
            Sifrelbl.Text = "Avm Adres";
            Telefonlbl.Text = "GEnel Müdürlük";
            Epostalbl.Text = "Kupon Kodu";

            try
            {

                LCWTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void LCWTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<LCW> list = sqlCon.Query<LCW>
                ("LCWArama", param, commandType: CommandType.StoredProcedure).ToList<LCW>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        class LCW
        {
            public int MagazaId { get; set; }

            public string YetkiliAd { get; set; }
            public string YetkiliTelefon { get; set; }

            public string AvmAdres { get; set; }

            public string GenelMüdürlük { get; set; }
            public int AvmId { get; set; }

            public string KuponKod { get; set; }



        }
        #endregion

        #region Mavi
        private void mavibtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;

            Adılbl.Text = "Yerkili Adı";
            Soyadılbl.Text = "Yerkili Telefon";
            Sifrelbl.Text = "Avm Adres";
            Telefonlbl.Text = "GEnel Müdürlük";
            Epostalbl.Text = "Kupon Kodu";

            try
            {

                MaviTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void MaviTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<Mavi> list = sqlCon.Query<Mavi>
                ("MaviArama", param, commandType: CommandType.StoredProcedure).ToList<Mavi>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        class Mavi
        {
            public int MagazaId { get; set; }

            public string YetkiliAd { get; set; }
            public string YetkiliTelefon { get; set; }

            public string AvmAdres { get; set; }

            public string GenelMüdürlük { get; set; }
            public int AvmId { get; set; }

            public string KuponKod { get; set; }



        }
        #endregion

        #region Defacto
        private void defaktobtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;

            Adılbl.Text = "Yerkili Adı";
            Soyadılbl.Text = "Yerkili Telefon";
            Sifrelbl.Text = "Avm Adres";
            Telefonlbl.Text = "GEnel Müdürlük";
            Epostalbl.Text = "Kupon Kodu";

            try
            {

                DefactoTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void DefactoTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<Defacto> list = sqlCon.Query<Defacto>
                ("DefactoArama", param, commandType: CommandType.StoredProcedure).ToList<Defacto>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        class Defacto
        {
            public int MagazaId { get; set; }

            public string YetkiliAd { get; set; }
            public string YetkiliTelefon { get; set; }

            public string AvmAdres { get; set; }

            public string GenelMüdürlük { get; set; }
            public int AvmId { get; set; }

            public string KuponKod { get; set; }



        }
        #endregion

        #region DR
        private void DRbtn_Click(object sender, EventArgs e)
        {

            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;

            Adılbl.Text = "Yerkili Adı";
            Soyadılbl.Text = "Yerkili Telefon";
            Sifrelbl.Text = "Avm Adres";
            Telefonlbl.Text = "GEnel Müdürlük";
            Epostalbl.Text = "Kupon Kodu";

            try
            {

                DRTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void DRTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<DR> list = sqlCon.Query<DR>
                ("MaviArama", param, commandType: CommandType.StoredProcedure).ToList<DR>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        class DR
        {
            public int MagazaId { get; set; }

            public string YetkiliAd { get; set; }
            public string YetkiliTelefon { get; set; }

            public string AvmAdres { get; set; }

            public string GenelMüdürlük { get; set; }
            public int AvmId { get; set; }

            public string KuponKod { get; set; }



        }
        #endregion

        #region FloReklam
        private void floreklambtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            Adılbl.Text = "Reklam Adı";
            Soyadılbl.Text = "Reklam Süresi";
            Sifrelbl.Text = "Reklam Ücreti";

            try
            {

                FloReklamTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void FloReklamTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<FloReklam> list = sqlCon.Query<FloReklam>
                ("FloReklamArama", param, commandType: CommandType.StoredProcedure).ToList<FloReklam>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
           // dataGridView1.Columns[5].Visible = false;
        }
        class FloReklam
        {
            public int MagazaId { get; set; }

            public string ReklamAdı { get; set; }
            public string ReklamSüresi { get; set; }

            public int ReklamÜcreti { get; set; }

         



        }
        #endregion

        #region MigrosReklam
        private void migrosreklambtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            Adılbl.Text = "Reklam Adı";
            Soyadılbl.Text = "Reklam Süresi";
            Sifrelbl.Text = "Reklam Ücreti";

            try
            {

                MigrosReklamTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void MigrosReklamTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<MigrosReklam> list = sqlCon.Query<MigrosReklam>
                ("MigrosReklamArama", param, commandType: CommandType.StoredProcedure).ToList<MigrosReklam>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            // dataGridView1.Columns[5].Visible = false;
        }
        class MigrosReklam
        {
            public int MagazaId { get; set; }

            public string ReklamAdı { get; set; }
            public string ReklamSüresi { get; set; }

            public int ReklamÜcreti { get; set; }





        }
        #endregion

        #region LCWReklam
        private void lcwreklambtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            Adılbl.Text = "Reklam Adı";
            Soyadılbl.Text = "Reklam Süresi";
            Sifrelbl.Text = "Reklam Ücreti";

            try
            {

                LCWReklamTablo();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void LCWReklamTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<LCWReklam> list = sqlCon.Query<LCWReklam>
                ("LCWReklamArama", param, commandType: CommandType.StoredProcedure).ToList<LCWReklam>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            // dataGridView1.Columns[5].Visible = false;
        }
        class LCWReklam
        {
            public int MagazaId { get; set; }

            public string ReklamAdı { get; set; }
            public string ReklamSüresi { get; set; }

            public int ReklamÜcreti { get; set; }





        }
        #endregion

        #region MaviReklam
        private void mavireklambtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            Adılbl.Text = "Reklam Adı";
            Soyadılbl.Text = "Reklam Süresi";
            Sifrelbl.Text = "Reklam Ücreti";

            try
            {
                MaviReklamTablo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void MaviReklamTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<MaviReklam> list = sqlCon.Query<MaviReklam>
                ("MaviReklamArama", param, commandType: CommandType.StoredProcedure).ToList<MaviReklam>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            // dataGridView1.Columns[5].Visible = false;
        }
        class MaviReklam
        {
            public int MagazaId { get; set; }

            public string ReklamAdı { get; set; }
            public string ReklamSüresi { get; set; }

            public int ReklamÜcreti { get; set; }





        }
        #endregion

        #region DefactoReklam
        private void dekaftoreklambtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            Adılbl.Text = "Reklam Adı";
            Soyadılbl.Text = "Reklam Süresi";
            Sifrelbl.Text = "Reklam Ücreti";

            try
            {
                DefactoReklamTablo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void DefactoReklamTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<DefactoReklam> list = sqlCon.Query<DefactoReklam>
                ("DefactoReklamArama", param, commandType: CommandType.StoredProcedure).ToList<DefactoReklam>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            // dataGridView1.Columns[5].Visible = false;
        }
        class DefactoReklam
        {
            public int MagazaId { get; set; }

            public string ReklamAdı { get; set; }
            public string ReklamSüresi { get; set; }

            public int ReklamÜcreti { get; set; }





        }
        #endregion

        #region DRReklam
        private void DRreklambtn_Click(object sender, EventArgs e)
        {
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adılbl.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = false;
            Telefontxt.Visible = false;
            Epostalbl.Visible = false;
            Epostatxt.Visible = false;
            Adılbl.Text = "Reklam Adı";
            Soyadılbl.Text = "Reklam Süresi";
            Sifrelbl.Text = "Reklam Ücreti";

            try
            {
                DRReklamTablo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void DRReklamTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<DRReklam> list = sqlCon.Query<DRReklam>
                ("DRReklamArama", param, commandType: CommandType.StoredProcedure).ToList<DRReklam>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            // dataGridView1.Columns[5].Visible = false;
        }
        class DRReklam
        {
            public int MagazaId { get; set; }

            public string ReklamAdı { get; set; }
            public string ReklamSüresi { get; set; }

            public int ReklamÜcreti { get; set; }





        }
        #endregion

        #region AVM Tablosu
        private void AVMbtn_Click(object sender, EventArgs e)
        {
            Soyadılbl.Text = "AVM Adres";
            Adılbl.Text = "AVM Adı";
            Sifrelbl.Text = "Yetkili Adı";
            Telefonlbl.Text = "Yetkili Telefon";
            Epostalbl.Text = "AVM Top Gelir";
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adıtxt.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;
            try
            {
                AVMTablo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void AVMTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<Avm> list = sqlCon.Query<Avm>
                ("AVMArama", param, commandType: CommandType.StoredProcedure).ToList<Avm>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
             dataGridView1.Columns[6].Visible = false;
        }
        class Avm
        {
            public int AvmId { get; set; }
            public string AvmAd { get; set; }
            public string AvmAdres { get; set; }
            public string YetkiliAdı { get; set; }
            public string YetkiliTelefon { get; set; }
            public string AvmTopGelir { get; set; }
            public int MuhasebeId { get; set; }





        }
        #endregion

        #region Muhasebe
        private void muhasebebtn_Click(object sender, EventArgs e)
        {
            Soyadılbl.Text = "Toplam Gider";
            Adılbl.Text = "Toplam Gelir";
            Sifrelbl.Text = "Net Kar";
            Telefonlbl.Text = "Faturalar";
            Epostalbl.Text = "Personel Maaş";
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adıtxt.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;
            try
            {
                MuhasebeTablo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void MuhasebeTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<Muhasebe> list = sqlCon.Query<Muhasebe>
                ("MuhasebeArama", param, commandType: CommandType.StoredProcedure).ToList<Muhasebe>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
        class Muhasebe
        {
            public int MuhasebeId { get; set; }
            public double ToplamGelir { get; set; }
            public double ToplamGider { get; set; }
            public double NetKar { get; set; }
            public double Faturalar { get; set; }
            public double PersonelMaas { get; set; }
            public int AvmId { get; set; }





        }
        #endregion

        #region Kolay Soru Tablosu
        private void kolaybtn_Click(object sender, EventArgs e)
        {
            Soyadılbl.Text = "a";
            Adılbl.Text = "Soru";
            Sifrelbl.Text = "b";
            Telefonlbl.Text = "c";
            Epostalbl.Text = "d"; 
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adıtxt.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;
            dogrucevaplbl.Visible = true;
            dogrucevaptxt.Visible = true;
            try
            {
                KolaySoruTablo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void KolaySoruTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<KolaySorular> list = sqlCon.Query<KolaySorular>
                ("KolaySorularArama", param, commandType: CommandType.StoredProcedure).ToList<KolaySorular>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
        class KolaySorular
        {
            public int KolaySoruId { get; set; }
            public string Soru { get; set; }
            public string a { get; set; }
            public string b { get; set; }
            public string c { get; set; }
            public string d { get; set; }
            public string DogruCevap { get; set; }

            public int SorularId { get; set; }





        }
        #endregion

        #region OrtaSorularTablo
        private void ortabtn_Click(object sender, EventArgs e)
        {
            Soyadılbl.Text = "a";
            Adılbl.Text = "Soru";
            Sifrelbl.Text = "b";
            Telefonlbl.Text = "c";
            Epostalbl.Text = "d";
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adıtxt.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;
            dogrucevaplbl.Visible = true;
            dogrucevaptxt.Visible = true;
            try
            {
                OrtaSoruTablo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void OrtaSoruTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<OrtaSorular> list = sqlCon.Query<OrtaSorular>
                ("OrtaSorularArama", param, commandType: CommandType.StoredProcedure).ToList<OrtaSorular>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
        class OrtaSorular
        {
            public int KolaySoruId { get; set; }
            public string Soru { get; set; }
            public string a { get; set; }
            public string b { get; set; }
            public string c { get; set; }
            public string d { get; set; }
            public string DogruCevap { get; set; }

            public int SorularId { get; set; }





        }
        #endregion

        #region ZorSorularTablosu
        private void zorbtn_Click(object sender, EventArgs e)
        {
            Soyadılbl.Text = "a";
            Adılbl.Text = "Soru";
            Sifrelbl.Text = "b";
            Telefonlbl.Text = "c";
            Epostalbl.Text = "d";
            Soyadıtxt.Visible = true;
            Soyadılbl.Visible = true;
            Adıtxt.Visible = true;
            Adıtxt.Visible = true;
            Sifrelbl.Visible = true;
            Sifretxt.Visible = true;
            Telefonlbl.Visible = true;
            Telefontxt.Visible = true;
            Epostalbl.Visible = true;
            Epostatxt.Visible = true;
            dogrucevaplbl.Visible = true;
            dogrucevaptxt.Visible = true;
            try
            {
                ZorSoruTablo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        void ZorSoruTablo()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", aratxt.Text.Trim());
            List<ZorSorular> list = sqlCon.Query<ZorSorular>
                ("ZorSorularArama", param, commandType: CommandType.StoredProcedure).ToList<ZorSorular>();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
        class ZorSorular
        {
            public int KolaySoruId { get; set; }
            public string Soru { get; set; }
            public string a { get; set; }
            public string b { get; set; }
            public string c { get; set; }
            public string d { get; set; }
            public string DogruCevap { get; set; }

            public int SorularId { get; set; }





        }
        #endregion
        #endregion // Çekme

        private void eklebtn_Click(object sender, EventArgs e)
        {
            #region Personel Detay tablosu


            try
            {
                if (Personeldetaybtn.Enabled == false)
                {

                    // personelgirişbtn.Enabled = false;
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                        //MessageBox.Show("Bağlandı");

                    }
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@KayıtID", id, DbType.Int32, ParameterDirection.Input, ((short)id));
                    param.Add("@Adı", Adıtxt.Text.Trim());
                    param.Add("@soyadı", Soyadıtxt.Text.Trim());
                    param.Add("@Telefon", Telefontxt.Text.Trim());
                    param.Add("@Adresi", Sifretxt.Text.Trim());
                    param.Add("@Email", Epostatxt.Text.Trim());

                    sqlCon.Execute
                        ("PersonelDetayTEkle", param, commandType: CommandType.StoredProcedure);
                    if (id == 0)
                    {
                        toolStripStatusLabel1.Text = "Kayıt oldu";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Güncelleme oldu";
                    }

                    PersonelDetayTablosu();
                    Clear();
                }
                else if (personelgirişbtn.Enabled == false)
                {

                    //Personeldetaybtn.Enabled = false;
                    // Personeldetaybtn.Enabled = false;
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                        //MessageBox.Show("Bağlandı");
                    }
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@KayıtID", idd, DbType.Int32, ParameterDirection.Input, ((short)idd));
                    param.Add("@Ad", Adıtxt.Text.Trim());
                    param.Add("@Soyad", Soyadıtxt.Text.Trim());
                    param.Add("@Sifre", Sifretxt.Text.Trim());


                    sqlCon.Execute
                        ("PersonelGirişEkle", param, commandType: CommandType.StoredProcedure);
                    if (idd == 0)
                    {
                        toolStripStatusLabel1.Text = "Kayıt oldu";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Güncelleme oldu";
                    }

                    FloTablo();
                    Clear();



                }
                else if (flobtn.Enabled == false)
                {
                    //Personeldetaybtn.Enabled = false;
                    // Personeldetaybtn.Enabled = false;
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                        //MessageBox.Show("Bağlandı");
                    }
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@KayıtID", idd, DbType.Int32, ParameterDirection.Input, ((short)idd));
                    param.Add("@AvmId", id, DbType.Int32, ParameterDirection.Input, ((short)id));
                    param.Add("@YetkiliAd", Adıtxt.Text.Trim());
                    param.Add("@YetkiliTelefon", Soyadıtxt.Text.Trim());
                    param.Add("@AvmAdres", Sifretxt.Text.Trim());
                    param.Add("@GenelMüdürlük", Telefontxt.Text.Trim());
                    param.Add("@KuponKod", Epostatxt.Text.Trim());




                    sqlCon.Execute
                        ("FloEkle", param, commandType: CommandType.StoredProcedure);
                    if (idd == 0)
                    {
                        toolStripStatusLabel1.Text = "Kayıt oldu";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Güncelleme oldu";
                    }

                    PersonelGrisTablosu();
                    Clear();
                }
              



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
            //return;





            #endregion
            #region Personel Giriş Tablosu





            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
            //finally
            //{
            //sqlCon.Close();

            //}







            #endregion

        }

       
    }
}
