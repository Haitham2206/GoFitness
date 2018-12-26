using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFitness
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogBrowse.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = openFileDialogBrowse.FileName.ToString();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                // SmtpClient client1 = new SmtpClient("smtp.live.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(txtEmail.Text);
                message.To.Add(txtTo.Text);
                message.Body = txtBody.Text;
                message.Subject = txtSubject.Text;

                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                if (txtAttachment.Text != "")
                {
                    message.Attachments.Add(new Attachment(txtAttachment.Text));
                }

                client.Credentials = new System.Net.NetworkCredential(txtEmail.Text, txtPassword.Text);
                client.Send(message);
                message = null;
                MessageBox.Show("message sent");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
