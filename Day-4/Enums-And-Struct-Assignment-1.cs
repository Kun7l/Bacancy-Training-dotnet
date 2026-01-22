using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    internal class Enums_And_Struct_Assignment_1
    {
        enum OrderStatus
        {
            Placed = 200,
            Cancelled = 400,
            Pending = 500
        }

        int getOrderStatus(OrderStatus status)
        {
            return (int)status;
        }

        //Struct 
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        //Struct vs class behaviour

        class PointClass {
            public int x; 
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static void Main(string[] args)
        {
            Enums_And_Struct_Assignment_1 es = new Enums_And_Struct_Assignment_1();
            // Enum
            Console.WriteLine(es.getOrderStatus(OrderStatus.Pending));

            //Struct
            Point p = new Point(10, 50);
            Console.WriteLine("X in struct before change : " + p.x);

            Point p1 = p;
            p1.x = 20;

            PointClass pc = new PointClass(10, 50);
            Console.WriteLine("X in class before change : " + pc.x);
            Console.WriteLine();

            PointClass pc1 = pc;
            pc1.x = 20;

            Console.WriteLine("X in struct after change : " + p.x);
            Console.WriteLine("X in class after change : " + pc.x);
        }
    }
}
