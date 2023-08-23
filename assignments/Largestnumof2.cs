using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Largestnumof2
    {
        static void Main(string[] args)
            // Write a code to find largest num from 2 num.
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("greatest num is" +num1);
            }
            else
            {
                Console.WriteLine("greatest num is" +num2);
            }
        }
    }
}
