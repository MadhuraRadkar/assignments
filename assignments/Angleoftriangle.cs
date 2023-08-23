using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Angleoftriangle
    {
        static void Main(string[] args)
            // Accept two angles of triangle and find third angle.
        {
            Console.WriteLine("Enter first angle");
            int angle1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second angle");
            int angle2 = Convert.ToInt32(Console.ReadLine());

            int angle3 = 180 - (angle1 + angle2);
            Console.WriteLine("The third angle is" +angle3);
        }
    }
}
