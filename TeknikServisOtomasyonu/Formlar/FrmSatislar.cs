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
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_UrunHareket
                           select new
                           {
                               u.HAREKETID,
                               u.TBL_Urun.AD,
                               u.TBL_Urun.MARKA,
                               MUSTERİ = u.TBL_Cari.AD + " " + u.TBL_Cari.SOYAD,
                               PERSONEL = u.TBL_Personel.AD + " " + u.TBL_Personel.SOYAD,
                               u.TARIH,
                               u.ADET,
                               u.FIYAT,
                               u.URUNSERINO
                               
                           };
            gridControl1.DataSource = degerler.ToList();

        }
    }
}
