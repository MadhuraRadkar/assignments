﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class PatternParallelogram
    {
    static void Main(string[] args)
        {     // Parallelogram pattern.
            for(int i=1; i<=8; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=8; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
        }
    }
}
                    //********
                     //********
                      //********
                       //********
                        //********
                         //********