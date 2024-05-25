using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1.Classes
{
    public abstract class Notification
    {
        public abstract void Send(string message);
    }

    public class SmsNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class GmailNotification: Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EmailNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
