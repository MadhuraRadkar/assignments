using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Sumofevennum
    {
        static void Main(string[] args)
            // Write a code to find sum of all even numbers from 1 to n.
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 2; i<=n; i+=2)
            {
                sum += i;
            }
            Console.WriteLine(" The sum of all even num is" +sum);
        }
    }
}
