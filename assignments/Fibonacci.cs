using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            // generate Fibonacci series. 0,1,2,3,5,8....k. where k<n. n is entered by user.
            Console.WriteLine("enter a no");
            int num =Convert.ToInt32(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;


            int i = 2;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            
            while(i<=num) 
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
                i++;
            }
        }
    }
}
