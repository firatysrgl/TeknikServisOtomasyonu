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
    public partial class FrmFaturaKalemler : Form
    {
        public FrmFaturaKalemler()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnAra_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(TxtID.Text);

            var degerler = ( from u in db.TBL_FaturaDetay
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           }).Where(x=>x.FATURAID==id);

            gridControl1.DataSource = degerler.ToList();
        }
    }
}
