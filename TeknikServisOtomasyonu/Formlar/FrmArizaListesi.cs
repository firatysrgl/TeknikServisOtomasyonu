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
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_UrunKabul
                           select new
                           {
                               x.ISLEMID,
                              
                               CARI = x.TBL_Cari.AD + x.TBL_Cari.SOYAD,
                               PERSONEL = x.TBL_Personel.AD + x.TBL_Personel.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARİHİ,
                               x.URUNSERINO,

                           };

            gridControl1.DataSource = degerler.ToList();
        }
    }
}
