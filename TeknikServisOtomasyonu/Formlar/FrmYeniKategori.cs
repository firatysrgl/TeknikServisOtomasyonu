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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_Kategori t = new TBL_Kategori();
            t.AD = TxtkategoriAd.Text;
            db.TBL_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureEdit13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtkategoriAd_Click(object sender, EventArgs e)
        {
            TxtkategoriAd.Text = "";
            TxtkategoriAd.Focus();
        }
    }
}
