using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_2
{
    internal class AppConfig
    {
      
        public string  AppName { get; }
        public string AppVersion { get; }
        public string Date { get; }

        internal AppConfig(string AppName, string AppVersion, string Date)
        {
            this.AppName = AppName; 
            this.AppVersion = AppVersion;
            this.Date = Date;
        }
    }
    class MakeApp
    {
        //static void Main(string[] args)
        //{
        //    AppConfig app = new AppConfig("Youtube", "1.0", "12/3/2005");
        //    Console.WriteLine(app.AppName);
        //    //app.AppName = "Instagram"; // Will give compile time error
        //}
    }
}
