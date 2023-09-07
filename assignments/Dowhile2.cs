using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Dowhile2
    {
        static void Main(string[] args)
            // WAP to print even numbers from 121 to 229 using dowhile loop.
        {
            int i = 121;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= 229);
        }
    }
}
