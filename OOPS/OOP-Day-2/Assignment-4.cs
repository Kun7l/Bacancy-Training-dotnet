using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_2
{
    interface ILogging
    {
        void Display();
    }
    interface IAuditing
    {
        void Display();
    }

    class Implement_Interface : ILogging,IAuditing
    {
         void ILogging.Display()
        {
            Console.WriteLine("ILogging working");
        }
        void IAuditing.Display() {
            Console.WriteLine("IAuditing working");
        }
    }

    class Assignment4
    {
        //static void Main(string[] args)
        //{
        //    Implement_Interface implement = new Implement_Interface();
        //    ((ILogging)implement).Display();
        //    ((IAuditing)implement).Display();
        //}
    }
}
