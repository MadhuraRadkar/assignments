﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Primenum1to10
    {
     static void Main(string[] args)
        {
            // write a code to display all the prime numbers between 1 to 10.

            for (int num=1; num<=10; num++)
            {
                bool isPrime = true;
                for (int i=2; i<num; i++)
                {
                    if ( num%i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(num);
                }
               


            }

        }
    }
}
