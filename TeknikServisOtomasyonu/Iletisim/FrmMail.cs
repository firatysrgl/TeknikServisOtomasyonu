using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServisOtomasyonu.Iletisim
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string frommail = "gonderici mail";
            string sifre = "şifreniz";
            string alici = TxtAlıcı.Text;
            string konu =TxtKonu.Text;
            string icerik =Txtİcerik.Text;

            mail.From = new MailAddress(frommail);
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(frommail, sifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);

            MessageBox.Show("Mail Gönderildi");



        }

        private void TxtAlıcı_Click(object sender, EventArgs e)
        {
            TxtAlıcı.Text = "";
        }

        private void TxtKonu_Click(object sender, EventArgs e)
        {
            TxtKonu.Text = "";
        }

        private void Txtİcerik_Click(object sender, EventArgs e)
        {
            Txtİcerik.Text = "";
        }

        private void FrmMail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
