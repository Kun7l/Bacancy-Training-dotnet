using System;
using System.IO;

namespace Logging
{
    public class FileLogger : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("File closed");
        }
        private string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            } 
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        FileLogger logger = new FileLogger("E:\\Bacancy-Training\\visual-studio\\Bacancy-Training-dotnet\\OOPS-Day-4\\test.txt");

    //        logger.Log("Application started");
    //        logger.Log("Something happened");
    //        logger.Dispose();
    //    }
    //}

}
