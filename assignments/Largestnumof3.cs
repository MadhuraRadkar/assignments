using System.ComponentModel.Design;

internal class Largestnumof3
       
{
    static void Main(string[] args)
    { 
        // To find the largest number of three numbers 
        int num1, num2, num3;
        Console.WriteLine("find the largest of three numbers");

        Console.WriteLine("Enter the first number");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("first number is greatest");
            }
            else
            {
                Console.WriteLine("Third number is greatest");
            }
        }
        else if (num2 > num3)
        {
            Console.WriteLine("second number is greatest");

        }

        else
        {
            Console.WriteLine("third number is greatest");
        }









    }


}