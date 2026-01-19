using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Assignment_4
    {
        public void func()
        {
            String username = null;

            Console.WriteLine("Enter 1 to type information or 0 for exit ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
            }

            String displayName = username ?? "Guest";

            Console.WriteLine("Hello " + displayName);
        }
    }
}