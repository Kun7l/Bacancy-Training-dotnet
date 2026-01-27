using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day_6
{
    internal class Async_Programming
    {
        public async Task<string> getData(int id) {
            Console.WriteLine("Fetching started Asynchronously");
            await Task.Delay(3000);
            Console.WriteLine("Fetching completed");
            return "_Krunalll7";
        }
        public string getDataSync(int id)
        {
            Console.WriteLine("Fetching started synchronously");
            Thread.Sleep(3000);
            Console.WriteLine("Fetching completed");
            return "_Krunalll7";
        }
        //static async Task Main(string[] args)
        //{

        //    Async_Programming ap = new Async_Programming();
        //    try
        //    {
        //        string? userName;

        //        //Get data with sync
        //        Stopwatch normalTimer = Stopwatch.StartNew();
        //        userName = ap.getDataSync(12);
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine("performing other tasks");
        //            await Task.Delay(1000);
        //        }
        //        Console.WriteLine("Response :" + userName);

        //        normalTimer.Stop();
        //        Console.WriteLine($"Sync Total Runtime (ms): {normalTimer.ElapsedMilliseconds} ms");


        //        Console.WriteLine();
        //        Console.WriteLine();

        //        //Get data with async

        //        Stopwatch asyncTimer = Stopwatch.StartNew();
        //        Task<string> apiTask = ap.getData(12);
        //        for (int i = 0; i < 5; i++)
        //        {
        //            await Task.Delay(1000);
        //            Console.WriteLine("performing other tasks");

        //        }
        //        Console.WriteLine("Response : " + apiTask.Result);

        //        asyncTimer.Stop();
        //        Console.WriteLine($"Async Total Runtime (ms): {asyncTimer.ElapsedMilliseconds} ms");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }


}
