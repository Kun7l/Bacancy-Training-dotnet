using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Day_4
{
    internal class CardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Rs {amount} paid using card");
        }
    }
}
