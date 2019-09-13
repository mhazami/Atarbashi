using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Message
{
    public class SendMail
    {
        public bool SendGroupMail(List<string> mails)
        {
            try
            {
                if (mails.Any())
                {
                    foreach (var mail in mails)
                    {
                        Send(mail);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SendSingleMail(string mail)
        {
            try
            {
                Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Send(string urltmail)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add(urltmail);
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch (Exception)
            {

            }
        }
    }
}
