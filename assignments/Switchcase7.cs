using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Switchcase7
    {
     static void Main(string[] args)
        {
            int num;
            num = 47;
            Console.WriteLine("num" + num);
            if (num % 3 == 0)
            {
                Console.WriteLine("divisible by 3");
            }
            else
            {
                Console.WriteLine("not divisible by 3");
            }
        }
    }
}
