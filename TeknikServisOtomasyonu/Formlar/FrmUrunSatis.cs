using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu.Formlar
{
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_UrunHareket t  = new TBL_UrunHareket();
            t.URUN= int.Parse(lookUpEdit1.EditValue.ToString());
            t.MUSTERI= int.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSONEL= short.Parse(lookUpEdit3.EditValue.ToString());
            t.TARIH= DateTime.Parse(TxtTarih.Text);
            t.ADET= short.Parse(TxtAdet.Text);
            t.FIYAT= decimal.Parse(TxtFiyat.Text);
            t.URUNSERINO= TxtSeriNo.Text;

            db.TBL_UrunHareket.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_Urun
                                         select new
                                         {
                                             x.ID,
                                             x.AD,
                                             x.MARKA
                                         }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBL_Cari
                                                 select new
                                                 {
                                                     x.ID,
                                                   AD=  x.AD +" "+x.SOYAD

                                                 }).ToList();

            lookUpEdit3.Properties.DataSource = (from x in db.TBL_Personel
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();


        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text= DateTime.Now.ToShortDateString();
        }

        private void TxtAdet_Click(object sender, EventArgs e)
        {
            TxtAdet.Text = "";
        }

        private void TxtFiyat_Click(object sender, EventArgs e)
        {
            TxtFiyat.Text = "";
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

        private void pictureEdit13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
