using DevExpress.XtraCharts;
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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBL_Urun.OrderBy(X=>X.MARKA).GroupBy(Y=>Y.MARKA).Select(Z=>new
            {
                Marka=Z.Key,
                Toplam=Z.Count()
            });
            gridControl1.DataSource = degerler.ToList();

            labelControl1.Text = (from x in db.TBL_Urun 
                                  select x.MARKA).Distinct().Count().ToString();
          
            labelControl3.Text = db.TBL_Urun.Count().ToString();

            labelControl7.Text = (from x in db.TBL_Urun
                                  orderby x.SATISFİYAT descending
                                  select x.MARKA).FirstOrDefault().ToString();

            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 600);
            chartControl1.Series["Series 1"].Points.AddPoint("Beko", 300);
            chartControl1.Series["Series 1"].Points.AddPoint("viessman", 250);
            chartControl1.Series["Series 1"].Points.AddPoint("Bosch", 400);

            chartControl2.Series["Kategoriler"].Points.AddPoint("Klima",72);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Kombi", 32);
            chartControl2.Series["Kategoriler"].Points.AddPoint("TV", 50);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Buz Dolabı", 13);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Fırın", 81);
            


        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit10_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
