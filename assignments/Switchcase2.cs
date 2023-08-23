using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Switchcase2
    {
        static void Main(string[] args)
        {
           // Create simple calculator using switch .

            Console.WriteLine("enter num1");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("enter num2");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("+,-,*,/,%");
            char option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '+':
                    decimal add = num1 + num2;
                    Console.WriteLine("addition is" + add);
                    break;

                case '-':
                    decimal substract = num1 - num2;
                    Console.WriteLine("substraction is" + substract);
                    break;

                case '*':
                    decimal multiplication = num1 * num2;
                    Console.WriteLine("multiplication is" + multiplication);
                    break;

                case '/':
                    decimal dividation = num1 / num2;
                    Console.WriteLine("division is " +dividation);
                    break;

                case '%':
                    decimal mod = num1 % num2;
                    Console.WriteLine("mod is" + mod);
                    break;

                default:
                    Console.WriteLine("invalid ");
                    break;


            }
        }
    }
}
