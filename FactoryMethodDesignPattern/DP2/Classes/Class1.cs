using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.Classes
{
    public abstract class Notification
    {
        public abstract void Send(string message);
    }

    public class SmsNotification : Notification
    {
        public override void Send(string message)
        {
            throw new NotImplementedException();
        }
    }
    public class GmailNotification: Notification
    {
        public override void Send(string message)
        {
            throw new NotImplementedException();
        }
    }

    public class ProductService
    {
        public void Add(int notificationType)
        {
            //Ürünleri Kaydet

            Notification notification = null;
            //1 = Gmail, 2 = Sms

            switch (notificationType)
            {
                case 1:
                    notification = new GmailNotification();
                    break;
                case 2:
                    notification = new SmsNotification();
                    break;
            }

            notification.Send("Ürün kaydedildi bu bir bilgilendirme mesajıdır.");
        }
    }
}
