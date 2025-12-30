using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            var degerler = db.TBL_Urun.OrderBy(X => X.MARKA).GroupBy(Y => Y.MARKA).Select(Z => new
            {
                Marka = Z.Key,
                Toplam = Z.Count()
            });
            gridControl1.DataSource = degerler.ToList();

            labelControl1.Text = (from x in db.TBL_Urun
                                  select x.MARKA).Distinct().Count().ToString();

            labelControl3.Text = db.TBL_Urun.Count().ToString();

            labelControl5.Text = db.maksurunmarka().FirstOrDefault();

            labelControl7.Text = (from x in db.TBL_Urun
                                  orderby x.SATISFİYAT descending
                                  select x.MARKA).FirstOrDefault().ToString();


            // CHART 1
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3KH2TAV\SQLEXPRESS;Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT MARKA,COUNT(*) FROM TBL_URUN GROUP BY MARKA", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();

            //CHART 2

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TBL_Kategori.AD,COUNT(*) FROM TBL_Urun INNER JOIN TBL_Kategori  ON TBL_Kategori.ID = TBL_Urun.KATEGORİ GROUP BY TBL_Kategori.AD"
                , baglanti);
            SqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();


        }

        
    }
}
