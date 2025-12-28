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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {

            var degerler = from u in db.TBL_FaturaBilgi
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERDIDAIRE,
                               CARI = u.TBL_Cari.AD + " " + u.TBL_Cari.SOYAD,
                               PERSONEL = u.TBL_Personel.AD + " " + u.TBL_Personel.SOYAD
 
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBL_Cari
                                                 select new
                                                 {
                                                     x.ID,
                                                    AD= x.AD + " " + x.SOYAD
                                                 }).ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBL_Personel
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_FaturaBilgi
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERDIDAIRE,
                               CARI = u.TBL_Cari.AD + " " + u.TBL_Cari.SOYAD,
                               PERSONEL = u.TBL_Personel.AD + " " + u.TBL_Personel.SOYAD

                           };
            gridControl1.DataSource = degerler.ToList();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_FaturaBilgi t = new TBL_FaturaBilgi();
            t.SERI = TxtSeri.Text;
            t.SIRANO = TxtSira.Text;
            t.TARIH = Convert.ToDateTime(TxtTarih.Text);
            t.SAAT = TxtSaat.Text;
            t.VERDIDAIRE = TxtVergiD.Text;
            t.CARI = int.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit1.EditValue.ToString());

            db.TBL_FaturaBilgi.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
