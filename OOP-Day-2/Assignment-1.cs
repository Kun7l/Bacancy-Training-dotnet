using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_2
{
    class TempratureBelowAbsoluteZero : Exception
    {
        public TempratureBelowAbsoluteZero(string message) : base(message) { }
    }
    internal class TempratureSensor
    {
        private int temprature;
        private List<int> tempratureHistory = new List<int>();
        public int Temprature { 
            get { return temprature; } 
            set { 
                if(value> -273){
                    temprature = value; 
                    tempratureHistory.Add(value);
                }
                else
                {
                        throw new TempratureBelowAbsoluteZero("Temperature cannot be below absolute zero");
                }
            }
        }

        public List<int> getHistory()
        {
            return tempratureHistory;
        }
    }
    class Program
    {
            //static void Main(string[] args)
            //{
            //    try
            //    {
            //        TempratureSensor sensor = new TempratureSensor();
            //        sensor.Temprature = 200;
            //        sensor.Temprature = 300;
            //        sensor.Temprature = 400;
                    
            //    }
            //    catch (TempratureBelowAbsoluteZero e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
        }
}
