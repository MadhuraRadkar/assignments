using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Ducknumber
    {
      static void Main(string[] args)
        {
            // write a code to  check the num is duck num or not.
            //number contains 0. ex. 301,650 are duck numbers.
            // 003 ,06 are not considered as duck number.
            Console.Write("Enter a number");
            string num = Console.ReadLine();

            bool isDuck = false;

            for (int i =1; i<num.Length; i++)
            {
                if (num[i] =='0')
                {
                    isDuck = true;
                    break;
                }
            }
            if (isDuck)
            {
                Console.WriteLine(num + "is a duck number");
            }
            else
            {
                Console.WriteLine(num + "is not duck num");
            }
        }
    }
}
