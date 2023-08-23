using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Class3
    {
     static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"addition is {c}");

            int d = a - b;
            Console.WriteLine($"substraction is {d}");

            int e = a * b;
            Console.WriteLine($"multiplication is {e}");

            int f = a / b;
            Console.WriteLine($"divison is {f}");

            int g = a % b;
            Console.WriteLine($"remainder is{g}");


        }






    }





}
