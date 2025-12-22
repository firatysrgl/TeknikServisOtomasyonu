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
            t.URUN= int.Parse(TxtID.Text);
            t.MUSTERI= int.Parse(TxtMusteri.Text);
            t.PERSONEL= short.Parse(TxtPersonel.Text);
            t.TARIH= DateTime.Parse(TxtTarih.Text);
            t.ADET= short.Parse(TxtAdet.Text);
            t.FIYAT= decimal.Parse(TxtFiyat.Text);
            t.URUNSERINO= TxtSeriNo.Text;

            db.TBL_UrunHareket.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
