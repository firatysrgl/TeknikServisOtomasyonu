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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in new DBTEKNIKSERVISEntities().TBL_Kategori
                                               select new
                                               {
                                                   x.ID,
                                                   x.AD
                                               }).ToList();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            TBL_Urun t = new TBL_Urun();
            t.AD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFİYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFİYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());


            db.TBL_Urun.Add(t);
            db.SaveChanges();

            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TxtUrunAd_Click(object sender, EventArgs e)
        {
            TxtUrunAd.Text = "";
            TxtUrunAd.Focus();
        }

        private void TxtMarka_Click(object sender, EventArgs e)
        {
            TxtMarka.Text = "";
            TxtMarka.Focus();
        }

        private void TxtAlisFiyat_Click(object sender, EventArgs e)
        {
            TxtAlisFiyat.Text = "";
            TxtAlisFiyat.Focus();
        }

        private void TxtSatisFiyat_Click(object sender, EventArgs e)
        {
            TxtSatisFiyat.Text = "";
            TxtSatisFiyat.Focus();
        }

        private void TxtStok_Click(object sender, EventArgs e)
        {
            TxtStok.Text = "";
            TxtStok.Focus();
        }

        private void pictureEdit13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
