using DP1.Classes;

namespace DP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void XIslemi()
        {
            SmsNotification smsNotification = new SmsNotification();
            smsNotification.Send("sms gönder");

            GmailNotification gmailNotification = new GmailNotification();
            gmailNotification.Send("gmail gönder");

            EmailNotification emailNotification = new EmailNotification();
            emailNotification.Send("email gönder");


        }
    }
}
