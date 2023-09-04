using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Areaofrectangle
    {
        static void Main(string[] args)
            // Write a code to calculate area of rectangle.
        {
            Console.WriteLine("Enter length of rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle");
            int width = Convert.ToInt32(Console.ReadLine());

            int area = length * width;

            Console.WriteLine("The area of rectangle is" +area);
        }
    }
}
