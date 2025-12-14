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

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            //FrmYeniUrun fr = new FrmYeniUrun();
           // fr.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
            TBL_Urun t = new TBL_Urun();
            t.AD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFİYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFİYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(TxtKategori.Text);

            db.TBL_Urun.Add(t);
            db.SaveChanges();

            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
