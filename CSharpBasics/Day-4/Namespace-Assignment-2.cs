using System;
using System.Collections.Generic;
using System.Text;
//using NameSpace1;

using NsObj = NameSpace1.NameSpaceDemo;


namespace NameSpace2
{
    public class NameSpaceDemo
    {
        public void display()
        {
            Console.WriteLine("Inside Namespace 2");
        }

        public static void Main(string[] args)
        {
            //To solve conflicts method -1

            //NameSpace1.NameSpaceDemo obj1 = new NameSpace1.NameSpaceDemo();
            //NameSpace2.NameSpaceDemo obj2 = new NameSpace2.NameSpaceDemo();    

            //obj1.display();
            //obj2.display();

            //Using alias
            NameSpaceDemo ns = new NameSpaceDemo();
            NsObj ns1 = new NsObj();

            ns.display();
            ns1.display();


        }
    }
}
