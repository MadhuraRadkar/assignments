using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Divisibleby
    {
        static void Main(string[] args)
            // wac to display number between 1 to 20 which are divisible by 5.
        {
            int num = 1;
            while (num <= 20)
            {
                if (num % 5 == 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
        }
    }
}
