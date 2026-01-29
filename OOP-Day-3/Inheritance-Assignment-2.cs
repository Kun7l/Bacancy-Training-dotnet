using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Day_3
{
    internal class Car
    {
        public string color;
        public Car(string color)
        {
            //logging statemenet from base
            Console.WriteLine("Car is created.");
            this.color = color;
        }
    }
    class Ferrari : Car {

        string name;
        //Calling base class constructor
        public Ferrari(string name,string color) : base(color) {
            this.name = name;
        }

        public void GetDetails() => Console.WriteLine($"Car : {color} Ferrai {name} ");
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Ferrari ferrari = new Ferrari("sf-19", "Red");
    //        ferrari.GetDetails();
    //    }
    //}

}
