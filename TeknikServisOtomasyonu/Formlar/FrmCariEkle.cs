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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_Cari t = new TBL_Cari();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.TELEFON = TxtTelefon.Text;
            t.MAIL = TxtMail.Text;
            t.IL = Txtİl.Text;
            t.ILCE = Txtİlce.Text;
            t.BANKA = TxtBanka.Text;
            t.VERGINO = TxtVergiN.Text;
            t.VERGIDAIRESI = TxtVergiD.Text;
            t.STATU = TxtStatu.Text;
            t.ADRES = TxtAdres.Text;

            db.TBL_Cari.Add(t);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
