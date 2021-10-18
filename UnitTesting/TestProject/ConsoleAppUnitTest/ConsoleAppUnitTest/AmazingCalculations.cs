using System;

namespace ConsoleAppUnitTest
{
    public class AmazingCalculations
    {
        private readonly IEmailNotification _emailNotification;
        private EmailSystem2000 emailSystem2000;
      
        public AmazingCalculations(IEmailNotification emailNotification) 
        {
            _emailNotification = emailNotification;
        }

        public object CalculateValue(string to, string from)
        {
            //throw new NotImplementedException();
            var calculatedValue = to.Length + from.Length;
            var now = DateTime.UtcNow;
            var subject = $"Status date: {now: 6}";
            //  var emailSystem = new EmailSystem2000();
            _emailNotification.SendMessage(to, from, subject, calculatedValue.ToString());
            return calculatedValue;
        }
    }
}