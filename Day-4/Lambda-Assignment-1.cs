using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    internal class Lambda_Assignment_1
    {

        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 5, 3, 1, 4, 9, 6, 8, 7, 10 };

            //Filter Even Numbers
            List<int> evenNums = numbers.Where(n => n % 2 == 0).ToList();
            foreach (var item in evenNums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Find maximum Element
            var max = numbers.Aggregate((a, b) => a > b ? a : b);
            var Max = int.MinValue;
            numbers.ForEach(n =>
           {
               if (n > Max)
                   Max = n;
           });
            Console.WriteLine(Max);

            Console.WriteLine();
            //Sort 
            numbers = numbers.OrderBy(n => n).ToList();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
