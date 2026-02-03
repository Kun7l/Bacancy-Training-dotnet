using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    public class Calculator
    {
        public int add(int x,int y) => x + y;
        public int sub(int x,int y) => x - y;
        public int mul(int x,int y) => x * y;
        public int div(int  x,int y) => x / y;
    }
    internal class Delegates_demo
    {
        //public static void Main(string[] args)
        //{
        //    Calculator calc = new Calculator();
        //    Func<int, int, int> operation;

        //    char choice;
        //    Console.WriteLine("Enter operator +,-,* or /");
        //    choice = Convert.ToChar(Console.ReadLine());
        //    Console.WriteLine("Enter A");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter B");
        //    int b = Convert.ToInt32(Console.ReadLine());
        //    switch (choice)
        //    {
        //        case '+':
        //            operation = calc.add;
        //            break;
        //        case '-':
        //            operation = calc.sub;
        //            break;
        //        case '*':
        //            operation = calc.mul;
        //            break;
        //        case '/':
        //            operation = calc.div;
        //            break;
        //        default:
        //            throw new InvalidOperationException();
        //    }

        //    int result = operation.Invoke(a,b);
        //    Console.WriteLine("Result : "+result);
        //}
    }
}
