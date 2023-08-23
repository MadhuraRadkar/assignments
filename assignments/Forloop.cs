using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Forloop
    {
        static void Main(string[] args)
        // print num from 1-10
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //print even num from 1-100

            //for (int i=1; i<=100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i.ToString());
            //    }


            //print odd num from 1-50

            //for (int i=1; i <= 50; i++)
            //{
            //    if (i%2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }



            //print the table of a num
            Console.WriteLine("Enter a num");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of " +num+":");
            for (int i =  1; i<=10; i++)
            {
                int result = num * i;
                Console.WriteLine(result);
            }




        }
    }
}          
