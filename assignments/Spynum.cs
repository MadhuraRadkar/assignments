using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Spynum
    {
        static void Main(String[] args)
        {
            // Find the given num is spy or not.
            Console.WriteLine("enter a num");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                product = digit;
                num /= 10;

            }
            if (sum == product)
            {
                Console.WriteLine("the num is spy");
            }
            else
            {
                Console.WriteLine("num is not spy");
            }
        }
    }
}
