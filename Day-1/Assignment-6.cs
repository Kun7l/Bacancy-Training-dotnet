using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Order
    {
        const int taxRate = 12;
        readonly int orderId;

        public Order(int orderId)
        {
            this.orderId = orderId;
        }

        void changeValues()
        {
            //Compiler time error below

            taxRate = 13;
            orderId = 12;

        }

        public static void Main(string[] args)
        {
            Order order = new Order(12);
            order.changeValues();
        }

    }

}