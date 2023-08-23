using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Pattern6
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    num++;
                    if (num % 2 == 0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}                // Draw pattern
                 // 10101
                 // 01010
                 // 10101
                 // 01010
                 // 10101