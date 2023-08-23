using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Class1
    {
      static void Main(string[] args)
        {
            int age = 22;
            string name = "Madhura";
            char gender = 'F';
            string city = "parali";
            double test2 = 88.56;
            decimal percentage = 85.80M;
            float test = 56.23F;
            bool value = true;

            // using +sign
            Console.WriteLine("My name is"   + name);
            Console.WriteLine("My age is"   + age);
            Console.WriteLine("My gender is"   + gender);




            // using placeholder {0}
            Console.WriteLine("my name is {0}, my age is {1} , my gender is {2}" ,name, age, gender);




            // using string interpolation $ sign

            Console.WriteLine($"my  name is {name} my age is {age} my gender is {gender}");


        }




    }
     

}

