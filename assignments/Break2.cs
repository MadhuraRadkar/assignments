﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Break2

    {
        // display number between 1 to 25 if any num is divisible by 11 then stop the display process.
        static void Main(string[] args)
        {
            //int i= 1;
            //while (i <= 25)
            //{
            //    if (i % 11 == 0)
            //    {
                    
            //        break;
            //    }
            //    i++;
            //    Console.WriteLine(i);
                
            //}


            // Using for loop
            for(int i = 1; i <= 25; i++)
            {
                if (i % 11 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
    }
}
