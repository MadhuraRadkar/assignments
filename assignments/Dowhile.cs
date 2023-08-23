using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Dowhile
    { // print value from 1 to  10 using dowhile.
        static void Main(string[] args)
        {
            int i = 1; //initial value

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10); // condition
        }
    }
}
