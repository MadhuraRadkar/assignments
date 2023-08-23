using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Kaprekarnumber
    {
        static void Main(string[] args)
        {
            // Write a code to check the number is Kaprekar number or not.
            Console.WriteLine("Enter a num");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int square = num * num;
            int copy = num;
            int power = 1 ;

            while (num > 0)
            {
                count++;
                num = num / 10;

            }
            for(int i=1; i<=count; i++)
            {
                power = power * 10;
            }
            int end = square % power;
            int start = square / power;
            Console.WriteLine(end+start);

            if (copy == (end + start))
            {
                Console.WriteLine("The number is Kaprekar");
            }
            else
            {
                Console.WriteLine(" THe number is not Kaprekar");
            }
        }
    }
}
