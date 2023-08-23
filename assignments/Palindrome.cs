using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Palindrome
    {
        static void Main(string[] args)
        { 
            // write code to find given number is palindrome or not.
            Console.WriteLine("enter num");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rev = 0;


            while(num != 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;

            }
            

            if (temp == rev)
            {
                Console.WriteLine("num is palindrome");
            }
            else
            {
                Console.WriteLine("num is not palindrome");
            }

        }
    }
}
