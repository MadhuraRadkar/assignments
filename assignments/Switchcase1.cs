using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Switchcase1
    {
        static void Main(string[] args)
            // write code to  check a num is even or odd using switch.
        {
            Console.WriteLine("Enter a num");
            int num = Convert.ToInt32(Console.ReadLine());


            switch (num % 2)
            {
                case 0:
                    Console.WriteLine("The num is even");
                    break;

                case 1:
                    Console.WriteLine("The num is odd");
                    break;

            }


        }
    }

 
    
}
