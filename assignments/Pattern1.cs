using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Pattern1
    {
        static  void Main(string[] args)
        {
            // Inverted right angle triangle pattern.
            for (int i=8; i>=1; i--)
            {
              for (int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}

                //********
               //*******
              //*****
             //***
            //**
           //*
