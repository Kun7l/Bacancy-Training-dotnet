using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Repository<T>
    {
        List<T> list = new List<T>();

        public void add(T item)
        {
            list.Add(item);
        }

        public void display()
        {
            foreach (var member in list)
            {
                Console.WriteLine(member);
            }
        }
    }
    internal class Generics_Assignment_1
    {
        void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args)
        {
            String a = "abc";
            String b = "bcd";
            Console.WriteLine("a before swap : " + a);
            Generics_Assignment_1 gs = new Generics_Assignment_1();
            gs.Swap(ref a, ref b);

            Console.WriteLine("a after swap : " + a);

            Repository<int> repo = new Repository<int>();
            repo.add(1);
            repo.add(2);
            repo.display();


        }
    }

    
}
