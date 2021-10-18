using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnitTest
{
    public class EmailSystem2000:IEmailNotification
    {
        internal void SendMessage(string to, string from, string subject, string body)
        {
            //throw new NotImplementedException();
            if (!to.isValidEmail() || !from.IsValidEmail())
            {
                throw new Exception("An email supplied is not valid!");
            }
            var message = new MailMessage(to, from)
            {
                Subject = subject,
                Body = body
            };
            using (var client = new SmtpClient("some.smtp.server.net"))
            {
                client.Send(message);
            }
        }

        void IEmailNotification.SendMessage(string to, string from, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
