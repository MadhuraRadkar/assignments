using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Tableofnum
    {
        static void Main(string[] args)
        {
            // write code to display table between 1 to 5 using nested loop.
            for(int i= 1; i<=5; i++)
            {
                for (int j=1; j<=10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
