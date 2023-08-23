using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Areaofequilateraltriangle
    {
        static void Main(string[] args)
            // Write a code to calculate the area of equilateral triangle.
        {
            Console.WriteLine("Enter length of equilateral triangle");
            int length = Convert.ToInt32(Console.ReadLine());

            double area = 0;
            for(int i=1; i<=length; i++)
            {
                area += Math.Sqrt(length * length - (length / 2) * (length / 2));
            }
            Console.WriteLine("The area of equilateral triangle is" +area/2);
        }
    }
}
