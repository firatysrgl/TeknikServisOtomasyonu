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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_FaturaDetay t = new TBL_FaturaDetay();
           
            t.URUN = TxtUrun.Text;
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.TUTAR = decimal.Parse(TxtTutar.Text);
            t.FATURAID = int.Parse(TxtFatura.Text);
            db.TBL_FaturaDetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_FaturaDetay
                          select new
                          {
                              u.FATURADETAYID,
                              u.URUN,
                              u.ADET,
                              u.FIYAT,
                              u.TUTAR,
                              u.FATURAID
                          };

            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_FaturaDetay
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };

            gridControl1.DataSource = degerler.ToList();
        }
    }
}
