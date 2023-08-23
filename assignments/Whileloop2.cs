using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Whileloop2
    {
        static void Main(string[] args)
        {
          // print even number from 1 to 50 using if switch.
          
            for(int i=1; i<=50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}