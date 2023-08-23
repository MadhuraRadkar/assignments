using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Krishnamurthynumber
    {
      static void Main(string[] args)
        {
            // write a code to check whether the number is Krishnamurthy or not.
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                int fact = 1;
                
                for( int i =1; i<=digit; i++)
                {
                    fact *= i;
                }
                sum += fact;
                temp /= 10;
            }
            if (sum == num)
            {
                Console.WriteLine(num + "is a Krishnamurthy number");
            }
            else
            {
                Console.WriteLine(num + "is not a Krishnamurthy number");
            }


        }
    }
}
           // Krishnamurthy num example 1 ,2, 145, 40585 etc.
