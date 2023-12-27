using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.UI.BackOffice.Araclar
{
    public partial class FrmYardim : DevExpress.XtraEditors.XtraForm
    {
        public FrmYardim()
        {
            InitializeComponent();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mm = new MailMessage();
            string frommail = "T.cakiroglu07@gmail.com";
            string sifre = "Tuncay6146107";
            string receiver = TxtAlici.Text;
            string subject = TxtKonu.Text;
            string content = richTextBox1.Text;
            mm.From = (new MailAddress(frommail));
            mm.To.Add(receiver);
            mm.Subject = subject;
            mm.Body = content;
            mm.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            string appPassword = "voaxjcghtayqzljj";
            smtp.Credentials = new NetworkCredential(frommail, appPassword);
            smtp.EnableSsl = true;
            smtp.Send(mm);
            MessageBox.Show("Mail Başarıyla Gönderildi.");
            this.Close();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}