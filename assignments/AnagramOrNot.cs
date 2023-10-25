using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{  // Write a program to check given strings are anagram or not.
    public class AnagramOrNot
    {
        static void Main(string[] args)
        {
            string s1 = "listen";
            string s2 = "silent";
            char[] ch = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch2);
            string s3 = new string(ch);
            string s4 = new string(ch2);
            if (s3 == s4)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not anagram");
            }
        }
    }
}
