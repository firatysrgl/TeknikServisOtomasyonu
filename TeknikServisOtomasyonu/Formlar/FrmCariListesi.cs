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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        void liste()
        {
            var degerler = from x in db.TBL_Cari
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.IL,
                               x.ILCE,

                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            liste();
            labelControl12.Text = db.TBL_Cari.Count().ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_Cari t = new TBL_Cari();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.IL = Txtİl.Text;
            t.ILCE = Txtİlce.Text;
            t.TELEFON = TxtTel.Text;
            t.BANKA = TxtBanka.Text;
            t.VERGIDAIRESI= TxtVD.Text;
            t.VERGINO = TxtVN.Text;
            t.STATU= TxtStatu.Text;
            t.ADRES = TxtAdres.Text;

            db.TBL_Cari.Add(t);
            db.SaveChanges();
            MessageBox.Show("Cari Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBL_Cari.Find(id);
            db.TBL_Cari.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Müşteri Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_Cari
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.IL,
                               x.ILCE,

                           };
          
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
