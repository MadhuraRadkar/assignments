using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Disariumnumber
    {
        static void Main(string[] args)
        {
            // Write a code to check the given number is Disarium number or not.
            Console.WriteLine("Enter a num");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
           int temp = num;
            while (num > 0)
            {
                count++;
                num = num / 10;

            }
            num = temp;
            while (num > 0)
            {
                int digit = num % 10;
                int power = 1;
                for( int i =1; i<=count; i++)
                {
                    power = power* digit;
                }
                sum = sum + power;
                count--;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("The number is disarium");
            }
            else
            {
                Console.WriteLine("The number is not disarium");
            }


        }
    }
}
