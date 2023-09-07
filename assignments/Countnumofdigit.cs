using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Countnumofdigit
    {
        static void Main(string[] args)
            // Write a program to count number of digits in any number.
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (num != 0)
            {
                count++;
                num /= 10;
            }
            Console.WriteLine("The count of digit in number is " +count);
        }
    }
}
