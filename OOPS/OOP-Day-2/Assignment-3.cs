using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_2
{
     interface INotification
    {
         void doNotify();
    }

     class EmailNotifiction : INotification
    {
       public void doNotify() {
            Console.WriteLine("Notification by Email");
        }
    }
    class SMSNotification : INotification {
        public void doNotify() {
            Console.WriteLine("Notification by SMS");
        }
    }

    class Client
    {
        //static void Main(string[] args)
        //{
        //    EmailNotifiction email = new EmailNotifiction();
        //    email.doNotify();

        //    SMSNotification sms = new SMSNotification();
        //    sms.doNotify();
        //}
    }
}
