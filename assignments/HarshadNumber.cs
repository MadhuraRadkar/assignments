using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class HarshadNumber
    {  // Write a code to check number is Harshad number or not.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsHarshadNumber(number))
            {
                Console.WriteLine(number + " is a Harshad number");
            }
            else
            {
                Console.WriteLine(number + " is not Harshad number");

            }
        }
        public static bool IsHarshadNumber(int number)
        {
            int sum = 0;
            int originalNumber = number;
            while(number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return originalNumber % sum == 0;

        }
    }
}
