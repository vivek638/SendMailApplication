/*
 * Downloaded from Csharpens.com
 * Dated : 29-4-2014
 * for explanation
 * http://www.csharpens.com/2014/04/send-email-in-c-sharp-with-file-attachment.html 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Include this 3 Libraries
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;

namespace Email_Sending_in_CSharp___csharpens.com
{
    public partial class Form1 : Form
    {
        string SenderEmail;
        string SenderPassword;
        string EmailAttachment;
        string EmailSubject;
        string EmailBody;
        string ReceiverEmail;

        bool AttachmentStatus = false; // Will check if any file is attached or not.

        public Form1()
        {
            InitializeComponent();
        }

        private void SendEmailButon_Click(object sender, EventArgs e)
        {
            SenderEmail = (SenderEmailTextBox.Text) + "@gmail.com";

            SenderPassword = SenderEmailPasswordTextBox.Text;

            EmailAttachment = AttachmentTextBox.Text;

            EmailSubject = EmailSubjectTextBox.Text;
            EmailBody = EmailBodyTextBox.Text;

            ReceiverEmail = ReceiverTextBox.Text;

            SendNotSendLabel.Text = "Deleivery Status : "+SendEmail(SenderEmail, SenderPassword, EmailAttachment, EmailSubject, EmailBody, AttachmentStatus, ReceiverEmail);

        }
        public bool SendEmail(string SenderEmail, string SenderPassword, string EmailAttachment, string EmailSubject, string EmailBody, bool AttachmentStatus,string ReceiverEmail)
        {
           
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(SenderEmail);
            mail.To.Add(ReceiverEmail);
            mail.Subject = EmailSubject;
            mail.Body = EmailBody;

            if (AttachmentStatus == true) // checking if any file is attached or not.
            {
                System.Net.Mail.Attachment attachment;
                EmailAttachment = AttachmentTextBox.Text;
                attachment = new System.Net.Mail.Attachment(EmailAttachment);
                mail.Attachments.Add(attachment);
            }

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(SenderEmail, SenderPassword);
            SmtpServer.EnableSsl = true;

            try
            {
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AttachmentTextBox.Enabled = false;
        }

        private void SenderEmailTextBox_Click(object sender, EventArgs e)
        {
            if (SenderEmailTextBox.Text == "myEmail")
            {
                SenderEmailTextBox.Text = "";
            }
        }

        private void AttachFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                AttachmentTextBox.Text = ofd.FileName;

                AttachmentStatus = true; //confirmation that the a file is attached.
            }
        }
    }
}
