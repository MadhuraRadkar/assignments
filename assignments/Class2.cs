using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Test2
    {
      static void Main(string[] args)
        {
            // accept values from user 
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter your percentage");
            double percentage = Convert.ToDouble(Console.ReadLine());

        }

    }
}
