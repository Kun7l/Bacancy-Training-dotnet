using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Day_2
{
    internal class Utility_Class
    {
       // Optional Parameter
       public void displayName(string name = "Guest")
        {
            Console.WriteLine($"hello {name}");

            //displayName("krunal") will print hello krunal. else it will print hello Guest.

        }

        //out param function        
        public void outFunction(out int n, out int x)
        {
            //Values should be assigned inside function.
            x = 15;
            n = 10;
            Console.WriteLine("Variable x " + x);   
            Console.WriteLine("Variable n " + n);   
        }

        //Artithmatic 
        public int Sum(int a,int b)
        {
            return a + b;
        }

        //public static void Main(string[] args)
        //{

           
        //    Utility_Class c = new Utility_Class();

        //    c.displayName("Krunal");
        //    c.displayName();


        //    c.outFunction(out int n,out int x);

        //    Console.WriteLine(c.Sum(2,3));
            
        //}
    }

}
