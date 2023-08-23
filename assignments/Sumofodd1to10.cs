using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Sumofodd1to10
    {
        static void Main(string[] args)
            // print sum of odd numbers from 1 to 10 using while loop.
        {
            int num = 1;
            int sum = 0;
            while (num <= 10)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
                num++;
            }
            Console.WriteLine("sum of odd numbers is" +sum);
        }
    }
}
