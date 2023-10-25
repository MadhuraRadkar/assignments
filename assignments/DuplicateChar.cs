using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class DuplicateChar
    {

        public string Get(string s1)
        {
            char[]ch=s1.ToCharArray();
            int count = 0;
          
            for (int i= 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        count++;
                        break;
                    }
                }
                if (count>=1)
                {
                     ch[i] = '\0';
                   // Console.WriteLine(count + "" + ch[i]);
                }
                 else
                {
                    Console.WriteLine(ch[i]);

                }
                
            }
            return "";
        }
        static void Main(string[] args)
        {
         DuplicateChar d1=new DuplicateChar();
        string result = d1.Get("aishwarya");
        Console.WriteLine(result);

        }
    }
}
