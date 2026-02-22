using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporate_training_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("E:\\Bacancy-Training\\visual-studio\\Bacancy-Training-dotnet\\EF-Core\\Corporate-training-management-system\\AppSettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            Console.WriteLine(configuration.GetConnectionString("localConnectionString"));
        }
    }
}
