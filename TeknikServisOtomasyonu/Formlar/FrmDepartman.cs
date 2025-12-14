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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBL_Departman
                                       select new
                                      {
                                          x.ID,
                                          x.AD
                                      }).ToList();

            labelControl12.Text = db.TBL_Departman.Count().ToString();
            labelControl14.Text = db.TBL_Personel.Count().ToString();
        }
    }
}
