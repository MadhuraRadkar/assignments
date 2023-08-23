using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Avgofdigit
    {
        // write a code to find the average of digits in a  num.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                count++;
                num /= 10;
            }
            double avg = sum / count;
            Console.WriteLine("The avg of digits in the num is" + avg);
        }
    }
}
