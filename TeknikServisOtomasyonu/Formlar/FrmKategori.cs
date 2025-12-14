using DevExpress.XtraEditors;
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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_Kategori
                           select new
                           {
                               x.ID,
                               x.AD
                           };
            gridControl1.DataSource = degerler.ToList();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_Kategori t = new TBL_Kategori();
            t.AD = TxtAd.Text;
            db.TBL_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_Kategori
                           select new
                           {
                               x.ID,
                               x.AD
                           };
            gridControl1.DataSource = degerler.ToList();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            int id = int.Parse(TxtID.Text);
            var deger = db.TBL_Kategori.Find(id);
            db.TBL_Kategori.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBL_Kategori.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
