using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal class Assignment_2
    {

        public static async Task Main(string[] args)
        {
            Task<int> t1 = Task.Run(() => { Console.WriteLine("thread 1 started"); Thread.Sleep(3000); return 10; });
            Task<int> t2 = Task.Run(() => { Console.WriteLine("thread 2 started"); Thread.Sleep(2000); return 20; });
            Task<int> t3 = Task.Run(() => { Console.WriteLine("thread 3 started"); Thread.Sleep(1000); return 30; });

            int[] result = await Task.WhenAll(t1, t2, t3);

            Console.WriteLine("All tasks completed");

        }
    }
}
