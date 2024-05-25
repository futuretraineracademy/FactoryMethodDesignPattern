using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3.Classes
{
    public abstract class Notification
    {
        public abstract void Send(string message);
    }
    public class GmailNotification : Notification
    {
        const string _fromGmail = "futuretraineracademy@gmail.com";
        const string _password = "123456";
        string _subject;
        public GmailNotification(string subject)
        {
            _subject = subject;
        }
        public override void Send(string message)
        {
            Console.WriteLine(_fromGmail);
            Console.WriteLine(_password);
            Console.WriteLine(_subject);
            Console.WriteLine($"Gmail Notification {message}");
        }
    }

    public class SmsNotification : Notification
    {
        const string _authToken = "ASCSADHAS!^131231";
        const string _fromPhoneNumber = "0555XXXXXX";
        string _toPhoneNumber;
        public SmsNotification(string toPhoneNumber)
        {
            _toPhoneNumber=toPhoneNumber;
        }
        public override void Send(string message)
        {
            Console.WriteLine(_authToken);
            Console.WriteLine(_fromPhoneNumber);
            Console.WriteLine(_toPhoneNumber);
            Console.WriteLine($"Sms Notification {message}");
        }
    }

    public interface INotificationFactory
    {
        Notification CreateInstance();
    }

    public class GmailNotificationFactory : INotificationFactory
    {
        string _subject;

        public GmailNotificationFactory(string subject)
        {
            _subject = subject;
        }

        public Notification CreateInstance()
        {
            return new GmailNotification(_subject);
        }
    }

    public class SmsNotificationFactory : INotificationFactory
    {
        string _toPhoneNumber;

        public SmsNotificationFactory(string toPhoneNumber)
        {
            _toPhoneNumber = toPhoneNumber;
        }

        public Notification CreateInstance()
        {
            return new SmsNotification(_toPhoneNumber);
        }
    }
}
