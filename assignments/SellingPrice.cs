using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class SellingPrice
    {    // The fun calculate_sellingprice(),Accepts parameters int cost_price , int_no of items and 
        //  int profit.return the selling price of atom in float  format.
        static float calculate_sellingprice(int cost,int items,int profit)
        {
            float res = cost + (cost * profit / 100);
            return res;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cost price");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num of items");
            int i2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter profit");
            int i3 = Convert.ToInt32(Console.ReadLine());
            float f = calculate_sellingprice(i1, i2, i3);
            Console.WriteLine(f.ToString("0.0"));
        }
    }
}
