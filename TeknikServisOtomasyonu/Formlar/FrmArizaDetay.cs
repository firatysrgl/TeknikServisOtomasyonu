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
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_UrunTakip t = new TBL_UrunTakip();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERINO = TxtSeriNo.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            db.TBL_UrunTakip.Add(t);
            

            TBL_UrunKabul tb = new TBL_UrunKabul();
            int URUNID = int.Parse(id.ToString());
            var deger = db.TBL_UrunKabul.Find(URUNID);
            deger.URUNDURUMDETAY = comboBoxEdit1.Text;
            db.SaveChanges();

            MessageBox.Show("Arıza Detayı Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string id,serino;

        private void pictureEdit13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmArizaDetay_Load(object sender, EventArgs e)
        {
            TxtSeriNo.Text = serino;
        }
    }
}
