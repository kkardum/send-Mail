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
using System.Runtime.InteropServices;
using System.Net.Mail;

namespace send_Mail
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
       );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void txtmail_Enter(object sender, EventArgs e)
        {
            if (txtmail.Text == "  Email")
            {
                txtmail.Clear();
                txtmail.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtmail_Leave(object sender, EventArgs e)
        {
            if (txtmail.Text == "")
            {
                txtmail.ForeColor = Color.FromArgb(200, 200, 200);
                txtmail.Text = "  Email";
            }
        }

        private void txtsub_Enter(object sender, EventArgs e)
        {
            if (txtsub.Text == "  Subject")
            {
                txtsub.Clear();
                txtsub.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtsub_Leave(object sender, EventArgs e)
        {
            if (txtsub.Text == "")
            {
                txtsub.ForeColor = Color.FromArgb(200, 200, 200);
                txtsub.Text = "  Subject";
            }
        }

        private void txtmess_Enter(object sender, EventArgs e)
        {
            if (txtmess.Text == "  Message")
            {
                txtmess.Clear();
                txtmess.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtmess_Leave(object sender, EventArgs e)
        {
            if (txtmess.Text == "")
            {
                txtmess.ForeColor = Color.FromArgb(200, 200, 200);
                txtmess.Text = "  Message";
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {

            if (txtmail.Text == "" || txtmail.Text == "  Email" || txtsub.Text == "" || txtsub.Text == "  Subject")
            {
                MessageBox.Show("please enter Email and Subject", "Send fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                string to, from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = txtmail.Text;
                from = "karlokardum0@gmail.com";
                pass = "Kretenkokremenko123";
                messageBody = txtmess.Text;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = "From : " + "<br>Message: " + messageBody;
                message.Subject = txtsub.Text;
                message.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    DialogResult code = MessageBox.Show("Email Sent Successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (code == DialogResult.OK)
                    {
                        txtmail.Clear();
                        txtsub.Clear();
                        txtmess.Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
