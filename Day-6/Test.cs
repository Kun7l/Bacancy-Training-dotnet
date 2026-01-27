using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    internal class Test
    {
        public async Task<int> doWork()
        {
            await Task.Delay(5000);
            Console.WriteLine("Working");
            return 10;
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            //Task<int> t1 = test.doWork();
            //int result = t1.Result;
            Console.WriteLine(test.doWork().Result);
        }
    }
}
