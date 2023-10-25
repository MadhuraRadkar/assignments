using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            // Accept a num from user and print it in reverse order.
            int num, reverse = 0, rem;
            Console.WriteLine("Enter a num");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                reverse =( reverse * 10) + rem;
                num /= 10;
            }
            Console.WriteLine("The reversed num is " + reverse);
        }
    }
}
