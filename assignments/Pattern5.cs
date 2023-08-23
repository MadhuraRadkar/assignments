using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Pattern5
    {
     static void Main(string[] args)
        {
            // diagonal.
            int max = 4;
            for(int i=1; i<=max; i++)
            {
              for(int j=1; j<=i; j++)
                {
                    if (j == 1 || j==i || i == max)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   

                }
                Console.WriteLine();
            }
        }
    }
}
