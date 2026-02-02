using System;

namespace OOPS_Day_4 {
    class SampleObject
    {
        private int id;

        public SampleObject(int id)
        {
            this.id = id;
            Console.WriteLine($"Constructor called for object {id}");
        }

        ~SampleObject()
        {
            Console.WriteLine($"Finalizer called for object {id}");
        }
    }

    class Demo
    {
        static void Main()
        {
            Console.WriteLine("Creating objects\n");

            for (int i = 1; i <= 5; i++)
            {
                SampleObject obj = new SampleObject(i);
            }

            Console.WriteLine("\nObjects created.");

            Console.WriteLine("Garbage Collection\n");

            GC.Collect();
            GC.WaitForPendingFinalizers();
            

            Console.WriteLine("\nGarbage Collection completed");
            Console.ReadLine();
        }
    }
}
