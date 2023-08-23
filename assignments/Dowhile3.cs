using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Dowhile3
    {
        static void Main(string[] args)
            // print num from 1 to 20 which are divisible by 5 using dowhile loop.
        {
            int num = 1;
            do
            {
                if (num % 5 == 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
            while (num <= 20);
        }
    }
}
