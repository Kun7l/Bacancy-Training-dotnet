using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Day_3
{
    internal class Loops_Assignment_1
    {
        // Printing prime numbers
        public void printPrime(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        bool isPrime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Guess game 
        public void guessGame(int n)
        {
            int input = 0;
            
            while (input != n)
            {
                Console.WriteLine("Enter a number");
                input = Convert.ToInt32(Console.ReadLine());

                if (input<n)
                {
                    Console.WriteLine("Guess higher\n");
                }
                else if(input > n)
                {
                    Console.WriteLine("Guess lower\n");
                }
            }
            Console.WriteLine("You've Guessed it correct");
        }

        //foreach to iterate over collections

        void foreachDemo()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }


        //    public static void Main(string[] args)
        //    {
        //        Loops_Assignment_1 loops = new Loops_Assignment_1();
        //        //Prime number
        //        loops.printPrime(10);

        //        //Guess game 
        //        Random rnd = new Random();
        //        int n = rnd.Next(11);
        //        loops.guessGame(n);


        //        //foreach 
        //        loops.foreachDemo();
        //    }
    }
}
