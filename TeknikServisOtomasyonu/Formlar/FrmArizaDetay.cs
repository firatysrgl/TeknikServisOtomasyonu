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
            t.SERINO= TxtSeriNo.Text;
            t.TARIH= DateTime.Parse(TxtTarih.Text);
            db.TBL_UrunTakip.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arıza Detayı Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
