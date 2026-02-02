using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Day_4
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
}
