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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBL_Departman
                                       select new
                                      {
                                          x.ID,
                                          x.AD
                                          
                                      }).ToList();

            labelControl12.Text = db.TBL_Departman.Count().ToString();
            labelControl14.Text = db.TBL_Personel.Count().ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_Departman t = new TBL_Departman();

            
                t.AD = TxtAd.Text;   
               db.TBL_Departman.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBL_Departman.Find(id);
            db.TBL_Departman.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            TBL_Departman t = new TBL_Departman();
            t.AD = TxtAd.Text;
           db.TBL_Departman.Add(t);
            db.SaveChanges();
            MessageBox.Show("Departman Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
           // TxtAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_Departman
                           select new
                           {
                               x.ID,
                               x.AD
                               
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
