﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Nestedloop3
    {
     static void Main(string[] args)
        {
          for(char i='A'; i <='D'; i++)
            {
              for(char j='A'; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
} 
               // A
               // AB
               // ABC
               // ABCD