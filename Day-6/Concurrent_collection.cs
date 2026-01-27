using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    internal class Concurrent_collection
    {
        List<int> list = new List<int>();
        ConcurrentBag<int> bag = new ConcurrentBag<int>();
        
        public void AddSetA()
        {
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
                bag.Add(i);
                Thread.Sleep(1);
            }
        }
        public void AddSetB()
        {
            for (int i = 1; i <=10; i++)
            {
                list.Add(i);
                bag.Add(i);
                Thread.Sleep(1);
            }
        }

        public static void Main(string[] args)
        {
            Concurrent_collection cc = new Concurrent_collection();
            cc.list.Add(0);
           
            Thread t1 = new Thread(cc.AddSetA);
            Thread t2 = new Thread(cc.AddSetB);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            int sumList = 0;
            int sumConBag = 0;
            foreach(var item in cc.list)
            {
                sumList += item;
            }
            foreach(var item in cc.bag)
            {
                sumConBag += item;
            }
            Console.WriteLine("By logic Adding 1-10 2 times result in total of 110");
            Console.WriteLine("If you get 110 in both, run again");
            Console.WriteLine("Sum of List " + sumList);
            Console.WriteLine("Sum of Concurrent Bag " + sumConBag);
        }
    }
}
