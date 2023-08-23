using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class EvenoddDisplay
    {
        // Display numbers between 1 to 50 if num is even display its square & if odd display negetive.
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if ( i % 2 == 0)
                {
                    Console.WriteLine( i * i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
