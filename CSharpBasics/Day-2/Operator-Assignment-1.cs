using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    internal class Calculator
    {
        // Arithmetic operators 
        public double add(double a,double b)
        {
            return a + b; 
        }
        public double sub(double a, double b)
        {
            return a - b;
        }
        public double mul(double a,double b) { 
            return a * b; 
        }
        public double div(double a,double b) {
            if (b == 0)
            {
                Console.WriteLine("Cant devide by zero");
                return 0;
            }
            return a / b;
        }

        // Comparison Operator
        public bool isEqual(double a, double b)
        {
            return a == b;
        }
        public bool isGreaterThan(double a, double b) { 
            return a> b;
        }
        public bool isLessThan(double a, double b)
        {
            return a < b;
        }
        public bool isGreaterOrEqual(double a, double b)
        {
            return a >= b;
        }
        public bool isLessOrEqual(double a, double b) {
            return a <= b;
         }

        //Compund assignment
        
        public double addWithComp(double a, double b)
        {
            a += b;
            return a;
        }

        public double subWithComp(double a, double b)
        {
            a -= b;
            return a;
        }


        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine(calc.add(2, 3));
            Console.WriteLine(calc.mul(2, 3));

            Console.WriteLine(calc.isLessOrEqual(5,1));
            Console.WriteLine(calc.isGreaterThan(8,3));

            Console.WriteLine(calc.addWithComp(4,5));
        }
    }
}
