using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Cubeofnumber
    {
        static void Main(string[] args)
            // Write a code to find cube of a number.
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int cube = num * num * num;
            Console.WriteLine("cube of num is" +cube);
        }
    }
}
