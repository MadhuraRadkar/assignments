using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Primeornot
    {
      static void Main(string[] args)
        {
            // WAP to accept a num from user and check num is prime or not.
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    a = 0;
                    break;
                }
            }
                if (a == 1)
                {
                    Console.WriteLine("prime num");
                }
                else
                {
                    Console.WriteLine("Not prime num");
                }
            
        }
    }
}
