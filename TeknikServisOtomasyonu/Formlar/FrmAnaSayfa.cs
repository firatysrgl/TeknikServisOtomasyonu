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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=(from x in db.TBL_Urun
                                     select new
                                     {
                                         
                                         x.AD,
                                         x.MARKA,
                                         x.STOK
                                     }).Where(x=>x.STOK<50).ToList();

            gridControl4.DataSource=(from y in db.TBL_Cari
                                     select new
                                     {
                                         
                                         y.AD,
                                         y.SOYAD,
                                         y.IL
                                     }).ToList();

            gridControl2.DataSource=db.urunkategori().ToList();

            DateTime bugun = DateTime.Today;

            var deger = (from x in db.TBL_Notlarım.OrderBy(k => k.ID)
                         where (x.TARIH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
            gridControl3.DataSource = deger.ToList();


            string konu1,ad1,konu2,ad2,konu3,ad3,konu4,ad4,konu5,ad5, konu6,ad6, konu7,ad7, konu8,ad8, konu9,ad9, konu10,ad10;


            konu1 = db.TBL_Iletisim.First(x => x.ID == 1).KONU;
            ad1= db.TBL_Iletisim.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = ad1 + " - " + konu1;

            konu2 = db.TBL_Iletisim.First(x => x.ID == 2).KONU;
            ad2 = db.TBL_Iletisim.First(x => x.ID == 2).ADSOYAD;
            labelControl2.Text = ad2 + " - " + konu2;

            konu3 = db.TBL_Iletisim.First(x => x.ID == 3).KONU;
            ad3 = db.TBL_Iletisim.First(x => x.ID == 3).ADSOYAD;
            labelControl3.Text = ad3 + " - " + konu3;

            konu4 = db.TBL_Iletisim.First(x => x.ID == 4).KONU;
            ad4 = db.TBL_Iletisim.First(x => x.ID == 4).ADSOYAD;
            labelControl4.Text = ad4 + " - " + konu4;

            konu5 = db.TBL_Iletisim.First(x => x.ID == 5).KONU;
            ad5 = db.TBL_Iletisim.First(x => x.ID == 5).ADSOYAD;
            labelControl5.Text = ad5 + " - " + konu5;

            konu6 = db.TBL_Iletisim.First(x => x.ID == 6).KONU;
            ad6 = db.TBL_Iletisim.First(x => x.ID == 6).ADSOYAD;
            labelControl6.Text = ad6 + " - " + konu6;

            konu7 = db.TBL_Iletisim.First(x => x.ID == 7).KONU;
            ad7 = db.TBL_Iletisim.First(x => x.ID == 7).ADSOYAD;
            labelControl7.Text = ad7 + " - " + konu7;

            konu8 = db.TBL_Iletisim.First(x => x.ID == 8).KONU;
            ad8 = db.TBL_Iletisim.First(x => x.ID == 8).ADSOYAD;
            labelControl8.Text = ad8 + " - " + konu8;

            konu9 = db.TBL_Iletisim.First(x => x.ID == 9).KONU;
            ad9 = db.TBL_Iletisim.First(x => x.ID == 9).ADSOYAD;
            labelControl9.Text = ad9 + " - " + konu9;

            konu10 = db.TBL_Iletisim.First(x => x.ID == 10).KONU;
            ad10 = db.TBL_Iletisim.First(x => x.ID == 10).ADSOYAD;
            labelControl10.Text = ad10 + " - " + konu10;





        }

       
    }
}
