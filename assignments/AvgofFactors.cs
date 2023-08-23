using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class AvgofFactors
    {
        static void Main(string[] args)
        {
            // Find the Average of Factors in given number.
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i=1; i<=number; i++)
            {
               if (number % i== 0)
                {
                    sum += i;
                    count++;
                }
            }
            Double avg = sum / count;

            Console.WriteLine("Avg of factors of given num is " + avg);
        }
    }
}
