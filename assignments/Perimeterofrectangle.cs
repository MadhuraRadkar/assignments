using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Perimeterofrectangle
    {
        static void Main(string[] args)
            // Accept length and width of rectangle and fine perimeter of rectangle.
        {
            Console.WriteLine("Enter length of rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle");
            int width = Convert.ToInt32(Console.ReadLine());

            int perimeter = 2 * (length + width);

            Console.WriteLine("perimeter of rectangle is" + perimeter);

        }
    }
}
