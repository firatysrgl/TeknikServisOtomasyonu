using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TeknikServisOtomasyonu.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_UrunKabul
                           select new
                           {
                               x.ISLEMID,

                               CARI = x.TBL_Cari.AD + " " + x.TBL_Cari.SOYAD,
                               PERSONEL = x.TBL_Personel.AD + " " + x.TBL_Personel.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARİHİ,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY

                           };

            gridControl1.DataSource = degerler.ToList();

            labelControl1.Text = db.TBL_UrunKabul.Count(x => x.URUNDURUM == true).ToString();
            labelControl5.Text = db.TBL_UrunKabul.Count(x => x.URUNDURUM == false).ToString();
            labelControl7.Text = db.TBL_UrunKabul.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            labelControl11.Text = db.TBL_UrunKabul.Count(x => x.URUNDURUMDETAY == "İptal Edildi").ToString();
            labelControl13.Text = db.TBL_UrunKabul.Count().ToString();
            labelControl15.Text = db.TBL_UrunKabul.Count(x => x.URUNDURUMDETAY == "Müşteri Onayı").ToString();

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3KH2TAV\SQLEXPRESS;Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*) FROM TBL_UrunKabul GROUP BY URUNDURUMDETAY", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();



        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetay fr = new FrmArizaDetay();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }
    }
}
