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

            t.CARI = int.Parse(TxtID.Text);
            t.GELISTARIHI = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL= short.Parse(TxtPersonel.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.TBL_UrunKabul.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Kaydı Başarıyla Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
