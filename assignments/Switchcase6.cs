﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Switchcase6
    {
        static void Main(string[] args)
            //find out  odd numbers between 1 to 20.
        {
            Console.WriteLine(" odd numbers from 1 to 20");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
