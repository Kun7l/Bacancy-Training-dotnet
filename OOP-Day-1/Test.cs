using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_1
{
    internal class Test
    {
       public virtual void Display()
        {
            Console.WriteLine("helo");
        }

    }
    internal class Test2 : Test
    {
       
        public override void Display()
        {
            Console.WriteLine("Override");
        }
    }
}
