using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Swap2number
    {
      static void Main(string[] args)
            // Write  a code to swap two numbers.
        {
            Console.WriteLine("Enter first num");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second num");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping the first num is" + num1);
            Console.WriteLine("After swapping the second num is" + num2);

        }
    }
}
