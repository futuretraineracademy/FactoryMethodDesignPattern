using DP3.Classes;

namespace DP3
{
    internal class Program
    {

        public Program(Notification notification)
        {
            notification.Send();
        }

        static void Main(string[] args)
        {

            INotificationFactory notificationFactory = new GmailNotificationFactory("Ürünler kaydedildi bilgilendirme");
            Notification gmailNotification = notificationFactory.CreateInstance();
            gmailNotification.Send("mesaj gönder");

            Console.WriteLine("\n");

            INotificationFactory smsNotificationFactory = new SmsNotificationFactory("0552XXXXXX");
            Notification smsNotification = smsNotificationFactory.CreateInstance();
            smsNotification.Send("mesaj gönder");
        }
    }
}
