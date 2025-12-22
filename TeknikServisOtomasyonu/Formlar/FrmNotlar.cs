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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBL_Notlarım.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource=db.TBL_Notlarım.Where(y => y.DURUM == true).ToList();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_Notlarım t = new TBL_Notlarım();
            t.BASLIK = TxtBaslik.Text;
            t.ICERIK = Txtİcerik.Text;
            t.DURUM= false;
            db.TBL_Notlarım.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBL_Notlarım.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBL_Notlarım.Where(y => y.DURUM == true).ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true)
            {
                int id = Convert.ToInt32(TxtID.Text);
                var deger = db.TBL_Notlarım.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
