using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Thinkquotient
    {     // if num is divisible by 3 print think, if divisible by 5  print quotient and 
         // if divisible by 3 & 5 print think quotient.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Think quotient");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Think");

            }
            else if(num % 5 == 0)
            {
                Console.WriteLine("Quotient");

            }
            else
            {
                Console.WriteLine(" The num is not divisible by 3 or 5");
            }



        }
    }
}
