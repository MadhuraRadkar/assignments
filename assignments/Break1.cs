using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Break1
    {
        static void Main(string[] args)
        {
            // Display num between 1 to 20 avoid the num which are divisible by 3 or 5.

            //int i = 1;
            //while (i <= 20)
            //{
            //    if (i % 3 != 0 && i % 5 != 0)
            //    {

            //        Console.WriteLine(i);
            //    }
            //    i++;
              
            //}
          


            // Using for loop
            for(int i = 0; i <= 20; i++)
            {
                if(i % 3 !=0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
           
        }
    }
}
