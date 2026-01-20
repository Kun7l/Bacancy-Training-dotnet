using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Day_2
{
    internal class Grade_system
    {

        // If-Else method
        public void calculateGradeByIf(int marks)
        {
            if (marks < 0 || marks > 100) { Console.WriteLine("Invalid Input"); }
            else
            {
                if (marks >= 90)
                {
                    Console.WriteLine("A grade");
                }
                else if (marks >= 70)
                {
                    Console.WriteLine("B grade");
                }
                else if (marks >= 50)
                {
                    Console.WriteLine("C grade");
                }
                else if (marks >= 0)
                {
                    Console.WriteLine("D grade");
                }
                else
                {
                    Console.WriteLine("Invalid marks");
                }
            }

        }

        //Switch-case method

        public void calculateGradeBySwitch(int marks)
        {
            if (marks < 0 || marks > 100) {Console.WriteLine("Invalid Input"); }
            else {
                switch (marks)
                {
                    case > 100:
                    case < 0:
                        Console.WriteLine("Invalid marks");
                        break;

                    case >= 90:
                        Console.WriteLine("A grade");
                        break;
                    case >= 70:
                        Console.WriteLine("B grade");
                        break;
                    case >= 50:
                        Console.WriteLine("C grade");
                        break;
                    case >= 0:
                        Console.WriteLine("D grade");
                        break;
                }
            }
        }

        //Switch expression 

        public void calculateGradeBySwtichExpression(int marks)
        {
            if(marks > 100 || marks < 0)
            {
                Console.WriteLine("Enter marks between 0 to 100");
            }
            string grade = marks switch
            {
                >= 90 and < 100 => "A grade",
                >= 70 => "B grade",
                >= 50 => "C grade",
                _ => "D grade"
            };

            Console.WriteLine(grade);
        }

        //public static void Main(string[] args)
        //{
        //    Grade_system gs = new Grade_system();

        //    gs.calculateGradeByIf(85);
        //    gs.calculateGradeBySwitch(65);
        //    gs.calculateGradeBySwtichExpression(35);
        //}

    }
}
