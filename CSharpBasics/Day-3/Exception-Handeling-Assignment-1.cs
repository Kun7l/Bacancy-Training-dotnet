using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class InsufficientBalance : Exception
    {   
        public InsufficientBalance() : base("Insufficient Balance") {
            
        }
    }
    internal class Banking_System
    {

        double balance;
        Banking_System(double balance)
        {
            this.balance = balance;
        }

        void widrawMoney(double widraw)
        {
            Console.WriteLine($"Processing to widraw {widraw} rupees");
            try
            {
                if (widraw > balance)
                {
                    throw new InsufficientBalance();
                }
                balance -= widraw;
                Console.WriteLine($"Succesfully widraw rupees {widraw}\n");
            }
            catch(InsufficientBalance ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            finally
            {
                Console.WriteLine($"Available Balance : {balance}\n");
            }
            
        }
        //public static void Main(string[] args)
        //{
        //    Banking_System bank = new Banking_System(1000);

        //    int n = 1;
        //    while (n != 0)
        //    {     
        //        Console.WriteLine("Enter Amound to widraw");
        //        double widraw = Convert.ToDouble(Console.ReadLine());
        //        bank.widrawMoney(widraw);
        //        Console.WriteLine();
        //        Console.WriteLine("Enter 0 to exit or any to continue");
        //        n = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine();
        //    }

        //}

    }
}
