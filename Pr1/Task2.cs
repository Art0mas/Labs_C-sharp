using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Task2
    {
        public delegate void NotificationHandler(string message);

        private void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
        private void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }

        public void Example()
        {
            NotificationHandler notification = SendEmail;
            notification += SendSMS;
            notification("Hello");
        }
    }
}
