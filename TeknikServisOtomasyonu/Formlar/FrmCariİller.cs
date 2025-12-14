using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServisOtomasyonu.Formlar
{
    public partial class FrmCariİller : Form
    {
        public FrmCariİller()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();

        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-3KH2TAV\SQLEXPRESS;Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
        private void FrmCariİller_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 25);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 18);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 15);
            //chartControl1.Series["Series 1"].Points.AddPoint("Antalya", 12);
            //chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 22);

            gridControl1.DataSource = db.TBL_Cari.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new {
                    İL = z.Key,
                    TOPLAM = z.Count()
                }).ToList();


            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT IL,COUNT(*) AS 'TOPLAM' FROM TBL_Cari GROUP BY IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), Convert.ToInt32(dr[1]));
            }
            baglanti.Close();
        }
    }
}
