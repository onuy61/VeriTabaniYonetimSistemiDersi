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

namespace Otomasyon_Ticari
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void frmMail_Load(object sender, EventArgs e)
        {
            txtMail.Text = mail;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("kendimail", "kendisifre");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(txtMail.Text);
            mesajim.From = new MailAddress("kendi mail");
            mesajim.Subject = txtKonu.Text;
            mesajim.Body = txtMail.Text;
            istemci.Send(mesajim);
        }
    }
}
