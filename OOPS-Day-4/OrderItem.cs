using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Day_4
{
    public class OrderItem
    {
        public string Name { get; }
        public double Price { get; }
        public double Quantity { get; }

        public OrderItem(string name, double price, double quantity)
        {
            this.Name = name; 
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
