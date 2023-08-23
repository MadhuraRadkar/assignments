using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Pattern2
    { 
     static void Main(string[] args)
        {
            // Right angle triangle pattern.
            for (int i=1; i<=8; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
              // *
              // **
              // ***
              // ****
              // *****
              // ******
              // *******
              // ********
    }
}
