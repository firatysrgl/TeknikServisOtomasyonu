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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_Personel
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL
                               
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBL_Departman
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //Personel1
            ad1 = db.TBL_Personel.First(x => x.ID == 1).AD;
            soyad1 = db.TBL_Personel.First(x => x.ID == 1).SOYAD;
            labelControl3.Text = ad1 + " " + soyad1;
            labelControl5.Text = db.TBL_Personel.First(x => x.ID == 1).TBL_Departman.AD;
            labelControl6.Text = db.TBL_Personel.First(x => x.ID == 1).MAIL;

            //Personel2
            ad2 = db.TBL_Personel.First(x => x.ID == 2).AD;
            soyad2 = db.TBL_Personel.First(x => x.ID == 2).SOYAD;
            labelControl10.Text = ad2 + " " + soyad2;
            labelControl9.Text = db.TBL_Personel.First(x => x.ID == 2).TBL_Departman.AD;
            labelControl8.Text = db.TBL_Personel.First(x => x.ID == 2).MAIL;

            //Personel3
            ad3 = db.TBL_Personel.First(x => x.ID == 3).AD;
            soyad3 = db.TBL_Personel.First(x => x.ID == 3).SOYAD;
            labelControl17.Text = ad3 + " " + soyad3;
            labelControl16.Text = db.TBL_Personel.First(x => x.ID == 3).TBL_Departman.AD;
            labelControl15.Text = db.TBL_Personel.First(x => x.ID == 3).MAIL;

            //Personel4
            ad4 = db.TBL_Personel.First(x => x.ID == 4).AD;
            soyad4 = db.TBL_Personel.First(x => x.ID == 4).SOYAD;
            labelControl23.Text = ad4 + " " + soyad4;
            labelControl22.Text = db.TBL_Personel.First(x => x.ID == 4).TBL_Departman.AD;
            labelControl21.Text = db.TBL_Personel.First(x => x.ID == 4).MAIL;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_Personel t = new TBL_Personel();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.MAIL = TxtMail.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());

            db.TBL_Personel.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_Personel
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL
                               
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBL_Departman
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
                                                 
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBL_Personel.Find(id);
            db.TBL_Personel.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            TBL_Personel t = new TBL_Personel();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.MAIL = TxtMail.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBL_Personel.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
