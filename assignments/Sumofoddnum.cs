using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Sumofoddnum
    {
        static void Main(string[] args)
            // find sum of all odd numbers from 1 to n.
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i= 1; i<=n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of all odd num is" +sum);
        }
    }
}
