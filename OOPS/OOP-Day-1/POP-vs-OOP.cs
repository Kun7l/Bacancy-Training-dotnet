using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_1
{
    internal class Procedural_Programming
    {
        public static int balance;
        public static int accountNumber;
        public static string name;

        public static void deposite(int amount)
        {
            balance += amount;
            Console.WriteLine("Amount deposited : " + amount);
        }
        public static void widraw(int amount)
        {
            balance -= amount;
            Console.WriteLine("Amount widrawn : " + amount);
        }


        //static void Main(string[] args)
        //{
        //    balance = 1000;
        //    accountNumber = 001;
        //    name = "Krunal khairanar";

        //    Console.WriteLine("Current balance is : " + balance);
        //    deposite(3000);
        //    Console.WriteLine("Current balance is : " + balance);
        //    widraw(1000);
        //    Console.WriteLine("Current balance is : " + balance);

        //    balance += 10000;
        //    Console.WriteLine("Current balance is : " + balance);

        //}
    }

    internal class BankAccount
    {
        protected double balance;
        private int accountNumber;
        private string name;


        internal BankAccount(string name, int initialBalance, int accountNumber)
        {
            this.name = name;
            balance = initialBalance;
            this.accountNumber = accountNumber;
        }

        internal double checkBalance()
        {
            return balance;
        }

        internal void deposite(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited succesfully rs {amount}");
                Console.WriteLine($"Current balance is rs {balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposite amound");
            }
        }

        internal void widraw(int amount) {
            if (amount > balance) {
                Console.WriteLine("Not enough money");
            }
            else if (amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn successfully rs {amount}");
                Console.WriteLine($"Current balance is rs {balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
    }

    internal class SavingsAccount : BankAccount
    {
        private int interestRate;
        internal SavingsAccount(string name, int initialBalance, int accountNumber, int interestRate) : base(name, initialBalance, accountNumber) {

            this.interestRate = interestRate;
        }

        internal void addInterest()
        {
            balance += (balance * interestRate) / 100;
        }

    }
    internal class Bank
    {
        public static void Main(string[] args)
        {

            SavingsAccount account = new SavingsAccount("Krunal", 1000, 001, 7);
            Console.WriteLine("Balance " + account.checkBalance());
            account.addInterest();
            Console.WriteLine("Balance " + account.checkBalance());

            account.deposite(1000);

            
        }
    }

}
