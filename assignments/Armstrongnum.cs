using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Armstrongnum
    {
        // WAP to accept a number from user and check number is armstrong or not.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("It is an armstrong num");
            }
            else
            {
                Console.WriteLine("It is not an armstrong num");
            }
        }
    }
}
