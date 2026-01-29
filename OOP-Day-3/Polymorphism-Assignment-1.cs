using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_3
{
   class PaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment via cash of Rs {amount}");
        }
        public virtual void ProcessPayment(string from,string to,double amount)
        {
            Console.WriteLine($"Processing transfer of Rs {amount} from {from} -> {to}");
        }
    }

    class CreditCard : PaymentProcessor
    {
        public override void ProcessPayment(string from, string to, double amount)
        {
            Console.WriteLine("Via Credit Card");
            Console.WriteLine($"Processing transfer of Rs {amount} from {from} -> {to}");
        }
    }
    class UPI : PaymentProcessor
    {
        public override void ProcessPayment(string from, string to, double amount)
        {
            Console.WriteLine("Via UPI");
            Console.WriteLine($"Processing transfer of Rs {amount} from {from} -> {to}");
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PaymentProcessor processor = new CreditCard();
    //        processor.ProcessPayment("krunal", "charvin", 3000);

    //        PaymentProcessor processor2 = new UPI();
    //        processor2.ProcessPayment("Krunal", "Rahul", 2000);
    //    }
    //}
}
