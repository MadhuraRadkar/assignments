using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Pattern4
    {
       static void Main(string[] arg)
        {  // Right angle triangle reflection.
            
            for( int i=1; i<=8; i++)
            {
                for(int j=8-1; j>=i; j--)
                {
                    Console.Write(" ");
                }
                for (int k=1; k<=i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
             //       *
             //      **
             //     ***
             //    ****
             //   *****
             //  ******
             // *******
             //********
