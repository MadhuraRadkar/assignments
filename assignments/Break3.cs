using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Break3
    {
        static void Main(string[] args)
            // Write code to  display even digit from the given number.
        {
           
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                int digit = num % 10;
                
                if (digit % 2 == 0)
                {
                    Console.WriteLine(digit);
                }
                num /= 10;

            }
          
        }
    }
}
