using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
   class Animal
    {
        public virtual void Display()
        {
            Console.WriteLine("Inside Animal");
        }
    }
    class Dog : Animal
    {
        public override void Display()
        {
            Console.WriteLine("Inside dog");
        }
    }
    class Puppy : Dog
    {
        public override void Display()
        {
            Console.WriteLine("Inside puppy");
        }

    }

    class TestMultilevel
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Display();
        }
    }
}
