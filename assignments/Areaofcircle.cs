using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Areaofcircle
    {
        static void Main(string[] args)
        {
            // write a code to calculate area of circle.
            Console.WriteLine("Enter the radius of circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Area of circle is" +area);
        }
    }
}
