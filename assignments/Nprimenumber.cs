using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Nprimenumber
    {
        static void Main(string[] args)
            // print all prime number from 1 to n.
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int num=1; num<=n; num++)
            {
                bool isprime = true;
                for ( int i=2; i<num; i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }

                }
                if (isprime)
                {
                    count++;
                    Console.WriteLine(num);
                }
                if (count == n)
                {
                    break;
                }
            }
        }
    }
}
