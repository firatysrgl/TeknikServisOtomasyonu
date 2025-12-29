using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisOtomasyonu.Formlar;

namespace TeknikServisOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formlar.FrmUrunListesi fr3;
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {

                fr3 = new Formlar.FrmUrunListesi();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        Formlar.FrmYeniUrun fr5;
        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {

                fr5 = new Formlar.FrmYeniUrun();
                fr5.Show();
            }
        }

        Formlar.FrmKategori fr2;
        private void BtnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Formlar.FrmKategori();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        Formlar.FrmYeniKategori fr4;
        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Formlar.FrmYeniKategori();
                fr4.Show();
            }

        }

        Formlar.Frmİstatistik fr6;
        private void Btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {

                fr6 = new Formlar.Frmİstatistik();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        Formlar.FrmMarkalar fr7;
        private void BtnMarkaİst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new Formlar.FrmMarkalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        Formlar.FrmCariListesi fr9;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {

                fr9 = new Formlar.FrmCariListesi();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        Formlar.FrmCariİller fr10;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {

                fr10 = new Formlar.FrmCariİller();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        Formlar.FrmCariEkle fr11;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {

                fr11 = new Formlar.FrmCariEkle();
                fr11.Show();
            }
        }

        Formlar.FrmDepartman fr12;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {

                fr12 = new Formlar.FrmDepartman();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }

        Formlar.FrmYeniDepartman fr13;
        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {

                fr13 = new Formlar.FrmYeniDepartman();
                fr13.Show();
            }
        }

        Formlar.FrmPersonel fr14;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {

                fr14 = new Formlar.FrmPersonel();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }

        private void BtnHesapMak_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

      
        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }


       

        Formlar.FrmNotlar fr17;
        private void BtnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)
            {

                fr17 = new Formlar.FrmNotlar();
                fr17.MdiParent = this;
                fr17.Show();
            }
        }

        Formlar.FrmArizaListesi fr8;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {

                fr8 = new Formlar.FrmArizaListesi();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        Formlar.FrmUrunSatis fr18;
        private void BtnUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr18 == null || fr18.IsDisposed)
            {
                fr18 = new Formlar.FrmUrunSatis();
                fr18.Show();
            }
        }

        Formlar.FrmSatislar fr19;
        private void BtnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr19 == null || fr19.IsDisposed)
            {

                fr19 = new Formlar.FrmSatislar();
                fr19.MdiParent = this;
                fr19.Show();
            }
        }
        Formlar.FrmArizaliUrunKaydi fr20;
        private void BtnArizaKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null || fr20.IsDisposed)
            {

                fr20 = new Formlar.FrmArizaliUrunKaydi();
                fr20.Show();
            }
        }
        Formlar.FrmArizaDetay fr21;

        private void BtnArizaAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr21 == null || fr21.IsDisposed)
            {

                fr21 = new Formlar.FrmArizaDetay();
                fr21.Show();
            }
        }

        Formlar.FrmArizaliUrunDetayListesi fr22;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr22 == null || IsDisposed)
            {
                fr22 = new Formlar.FrmArizaliUrunDetayListesi();
                fr22.MdiParent = this;
                fr22.Show();
            }
        }

        Formlar.FrmQRCode fr23;
        private void BtnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr23 == null || IsDisposed)
            {

                fr23 = new Formlar.FrmQRCode();
                fr23.Show();
            }
        }

        Formlar.FrmFaturaListesi fr24;
        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr24 == null || IsDisposed)
            {
                fr24 = new Formlar.FrmFaturaListesi();
                fr24.MdiParent = this;
                fr24.Show();
            }
        }

        Formlar.FrmFaturaKalem fr25;
        private void BtnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr25 == null || IsDisposed)
            {
                fr25 = new Formlar.FrmFaturaKalem();
                fr25.MdiParent = this;
                fr25.Show();
            }
        }

        Formlar.FrmFaturaKalemler fr26;
        private void BtnFaturaKalemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr26 == null || IsDisposed)
            {
                fr26 = new Formlar.FrmFaturaKalemler();
                fr26.MdiParent = this;
                fr26.Show();
            }
        }


        Formlar.FrmRapor fr27;
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr27 == null || IsDisposed)
            {

                fr27 = new Formlar.FrmRapor();
                fr27.Show();
                
            }
        }

        Formlar.FrmAnaSayfa fr;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr == null || IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        Iletisim.FrmRehber fr28;
        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr28 == null || IsDisposed)
            {
                fr28 = new Iletisim.FrmRehber();
                fr28.MdiParent = this;
                fr28.Show();
            }

        }

        Iletisim.FrmMesajKutusu fr29;
        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr29 == null || IsDisposed)
            {
                fr29 = new Iletisim.FrmMesajKutusu();
                fr29.MdiParent = this;
                fr29.Show();
            }
        }

        Iletisim.FrmMail fr30;
        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr30 == null || IsDisposed)
            {

                fr30 = new Iletisim.FrmMail();
                fr30.Show();

            }
        }


        Formlar.FrmKurlar fr15;
        private void BtnKur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {

                fr15 = new Formlar.FrmKurlar();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }

        private void BtnWeb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Web sitesini varsayılan tarayıcıda (Chrome vb.) açar
            string siteAdresi = "https://localhost:44368/Default.aspx";

            try
            {
                System.Diagnostics.Process.Start(siteAdresi);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
