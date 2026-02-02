using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Day_4
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.Write("Email sent: "+message);
        }
    }
}
