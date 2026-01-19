using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Person
    {
        public String name;
    }
    class Program
    {
        static void Change(Person p, int b)
        {
            p.name = "rahul";
            b = 11;
        }
        //static void Main(string[] args)
        //{

        //    Person p = new Person();

        //    p.name = "Krunal";
        //    int b = 10;

        //    Console.WriteLine(p.name);
        //    Console.WriteLine(b);

        //    Change(p, b);

        //    Console.WriteLine(p.name);
        //    Console.WriteLine(b);
        //}

        

    }
}