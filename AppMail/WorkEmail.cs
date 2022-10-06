using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace AppMail
{
    class WorkEmail
    {
        AuthJira jira = new AuthJira();

        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        private string emailFromAddress =string.Empty; 
        private string passwordFrom = string.Empty; 
        private string _emailToAddress;   
        static string subject = "Information from Jira";
        private string body = string.Empty;

        public WorkEmail(TextBox emailFrom, TextBox passwordFrom)
        {
            this.emailFromAddress = emailFrom.Text;
            this.passwordFrom = passwordFrom.Text;
        }
        public async void SendEmail(TextBox name, TextBox password, TextBox host)
        {

             await jira.GetDataProjects(name,password,host);
            _emailToAddress = jira.emailToAddres;
            body = jira.BodyEmail;
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(_emailToAddress);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                   
                    smtp.EnableSsl = enableSSL;
                    smtp.Credentials = new NetworkCredential(emailFromAddress, passwordFrom);
                    smtp.Send(mail);
                }
            }
        }



    }
}
