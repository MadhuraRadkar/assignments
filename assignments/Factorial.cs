using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int no = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            int i = 1;
            while (i <= no)
            {
                factorial = factorial * i;
                i++;

            }
            Console.WriteLine(factorial);
        }
    }
}
