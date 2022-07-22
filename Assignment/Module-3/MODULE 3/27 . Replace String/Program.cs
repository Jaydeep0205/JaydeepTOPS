using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Replace_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "I am Learning C++";

            Console.WriteLine("Old String : "+s);


            s= s.Replace("C++", "C#");
            Console.WriteLine("\nNew String After Replacement ");
            Console.WriteLine("\nNew Strnig : "+s);


            Console.Read();
        }
    }
}
