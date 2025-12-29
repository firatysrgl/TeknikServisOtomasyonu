using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBL_Admin
                       where x.KULLANICIAD == textBox1.Text && x.SIFRE == textBox2.Text
                       select x;

            if (sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
               
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
