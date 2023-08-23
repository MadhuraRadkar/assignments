using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Sum2
    {
      // Write a code to print numbers from 1 to 10 and its sum.
      static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("sum:" +sum);
        }
    }
}
