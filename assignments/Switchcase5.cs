using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Switchcase5
    {
        static void Main(string[] args)
            // find out the sum of even number between 1 to 10.
        {
            int sum = 0;
           

            for (int i=2; i<=10; i++)
            {
                sum += i;
                
            }
            Console.WriteLine($" sum of even number between 1 to 10 is " + sum);

        }
    }
}
