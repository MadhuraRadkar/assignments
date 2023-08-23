using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Productofdigits
    {
        static void Main(string[] args)
            // Write a program to calculate product of digits in any number.
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int product = 1;

            while (num > 0)
            {
                product *= num % 10;
                num /= 10;
            }
            Console.WriteLine("The product of digits in the num is" +product);
        }
    }
}
