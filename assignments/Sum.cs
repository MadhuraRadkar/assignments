using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Sum
    {
        static void Main(string[] args)
            //sum of all digits of a number using while loop.
        {
            Console.WriteLine("enter digit");
            int num = Convert.ToInt32(Console.ReadLine());
            int  sum = 0;

            while (num !=0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("sum is" +sum);
            

        }
    }
}
