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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_UrunKabul t = new TBL_UrunKabul();
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.GELISTARIHI = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUM = false;
            t.URUNDURUMDETAY = "Arıza Kaydı Oluşturuldu";
            db.TBL_UrunKabul.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Kaydı Başarıyla Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //müşteri
            lookUpEdit1.Properties.DataSource = (from x in new DBTEKNIKSERVISEntities().TBL_Cari
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD

                                                 }).ToList();

            //personel
            lookUpEdit2.Properties.DataSource = (from x in new DBTEKNIKSERVISEntities().TBL_Personel
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }
    }
}
