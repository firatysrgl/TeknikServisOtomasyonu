using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu.Iletisim
{
    public partial class FrmMesajKutusu : Form
    {
        public FrmMesajKutusu()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmMesajKutusu_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBL_Iletisim
                                       select new
                                       {
                                           x.ADSOYAD,
                                           x.MAIL,
                                           x.KONU,
                                           x.MESAJ

                                       }).ToList();
        }
    }
}
