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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBL_Urun.Count().ToString();

            labelControl3.Text = db.TBL_Kategori.Count().ToString();

            labelControl5.Text = db.TBL_Urun.Sum(x => x.STOK).ToString();

            labelControl7.Text = "10";

            labelControl11.Text= (from x in db.TBL_Urun
                                  orderby x.STOK descending
                                    select x.AD).FirstOrDefault();

            labelControl13.Text = (from x in db.TBL_Urun
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();

           labelControl15.Text = db.makskategoriurun().FirstOrDefault();



            labelControl17.Text = (from x in db.TBL_Urun
                                   orderby x.SATISFİYAT descending
                                   select x.AD).FirstOrDefault();

            labelControl19.Text = (from x in db.TBL_Urun
                                      orderby x.SATISFİYAT ascending
                                      select x.AD).FirstOrDefault();

            labelControl21.Text = db.TBL_Urun.Where(x => x.KATEGORI == 1).Sum(x => x.STOK).ToString();

            labelControl23.Text = db.TBL_Urun.Where(x => x.KATEGORI == 4).Sum(x => x.STOK).ToString();

            labelControl31.Text = db.TBL_UrunKabul.Count().ToString();

            labelControl33.Text = db.maksurunmarka().FirstOrDefault();

            labelControl35.Text= (from x in db.TBL_Urun
                                  select x.MARKA).Distinct().Count().ToString();

            labelControl37.Text = db.TBL_Urun.Where(x => x.KATEGORI == 5).Sum(x => x.STOK).ToString();
        }
    }
}
