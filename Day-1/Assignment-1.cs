using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Assignment1
    {
        public void func()
        {
            String name = "Krunal Khairanar";
            String date = DateTime.Now.ToString("dd/MM/yyyy");
            String machineName = Environment.MachineName;

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Date : " + date);
            Console.WriteLine("Machine Name :" + machineName);

            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + "'s" + " age is : " + age);

        }

    }


}
