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

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureEdit13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAd_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
        }

        private void TxtSoyad_Click(object sender, EventArgs e)
        {
            TxtSoyad.Text = "";
        }

        private void TxtTelefon_Click(object sender, EventArgs e)
        {
            TxtTelefon.Text = "";
        }

        private void TxtMail_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtMail_Click(object sender, EventArgs e)
        {
            TxtMail.Text = "";
        }

        private void Txtİl_Click(object sender, EventArgs e)
        {
            Txtİl.Text = "";
        }

        private void Txtİlce_Click(object sender, EventArgs e)
        {
            Txtİlce.Text = "";
        }

        private void TxtBanka_Click(object sender, EventArgs e)
        {
            TxtBanka.Text = "";
        }

        private void TxtVergiD_Click(object sender, EventArgs e)
        {
            TxtVergiD.Text = "";
        }

        private void TxtVergiN_Click(object sender, EventArgs e)
        {
            TxtVergiN.Text = "";
        }

        private void TxtStatu_Click(object sender, EventArgs e)
        {
            TxtStatu.Text = "";
        }

        private void TxtAdres_Click(object sender, EventArgs e)
        {
            TxtAdres.Text = "";
        }
    }
}
