using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUnitTest
{
    public interface IEmailNotification
    {
        void SendMessage(string to, string from, string subject, string body);
    }
}
