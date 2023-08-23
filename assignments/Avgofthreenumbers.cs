using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Avgofthreenumbers
    {
      static void Main(string[] args)
            // Write  a code to calculate average of three numbers.
        {
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int avg = (num1 + num2 + num3) / 3;

            Console.WriteLine("Avg of three numbers is" +avg);

        }
    }
}
