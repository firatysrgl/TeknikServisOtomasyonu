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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        void metot1()
        {
            var degerler = from u in db.TBL_Urun
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI = u.TBL_Kategori.AD,
                               u.STOK,
                               u.ALISFİYAT,
                               u.SATISFİYAT

                               
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
          //  var degerler = db.TBL_Urun.ToList();
         metot1();
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_Kategori.ToList()
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_Urun t = new TBL_Urun();
            t.AD = TxtUrunAdi.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFİYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFİYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.DURUM = false;
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db .TBL_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtUrunAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFİYAT").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFİYAT").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            lookUpEdit1.Text= gridView1.GetFocusedRowCellValue("KATEGORI").ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBL_Urun.Find(id);
            db.TBL_Urun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBL_Urun.Find(id);
            deger.AD = TxtUrunAdi.Text;
            deger.STOK = short.Parse(TxtStok.Text);
            deger.MARKA = TxtMarka.Text;
            deger.ALISFİYAT = decimal.Parse(TxtAlisFiyat.Text);
            deger.SATISFİYAT = decimal.Parse(TxtSatisFiyat.Text);
            deger.KATEGORI= byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAlisFiyat.Text = "";
            TxtID.Text = "";
            TxtMarka.Text = "";
            TxtSatisFiyat.Text = "";
            TxtStok.Text = "";
            TxtUrunAdi.Text = "";

        }
    }
}
