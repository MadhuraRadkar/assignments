using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Breakforloop
    {
        static void Main(string[] args)
            // WAP to show use of break statement in for loop.
        {
            for (int i = 1; i<=20; i++)
            {
                if (i == 15)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
