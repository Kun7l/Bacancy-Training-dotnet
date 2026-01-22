using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{

    public static class Extension_Functions
    {
        static int CountWhiteSpace(this string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    count++;
                }

            }
            return count;
        }
        //public static void Main(string[] args) {
        //    String sentence = "Ahmedabad is located in gujarat";
        //    Console.WriteLine(sentence.CountWhiteSpace());
        //}
    }
}
