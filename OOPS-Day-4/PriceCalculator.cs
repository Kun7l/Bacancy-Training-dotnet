using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Day_4
{
    internal class PriceCalculator : IPriceCalculator
    {
        public double CalculateTotal(Order order) {
            double totalCost = 0;
            foreach(var item in order.Items)
            {
                totalCost += item.Price * item.Quantity;
            }
            return totalCost;
        }
        
    }
}
