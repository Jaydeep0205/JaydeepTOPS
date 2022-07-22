using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.String_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            string J = "    Jaydeep Chovatiya   ";

            Console.WriteLine("String Name : \n");
            Console.WriteLine(J);

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nString In UPPER Case : \n");
            Console.WriteLine(J.ToUpper());

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nString In LOWER Case : \n");
            Console.WriteLine(J.ToLower());

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nString Length : \n");
            Console.WriteLine(J.Length);

            Console.WriteLine("---------------------------");
            J = J.Replace("Jaydeep", "Jay");
            Console.WriteLine("\nNew String : \n");
            Console.WriteLine(J);

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nString Contains 'Chovatiya' : \n");
            Console.WriteLine(J.Contains("Chovatiya"));

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nString After Trim : \n");
            Console.WriteLine(J.TrimStart());


            Console.WriteLine("---------------------------");
            string a = "Chovatiya ";
            string b = "Jaydeep";

            Console.WriteLine("\nConcate String : \n");
            Console.WriteLine(string.Concat(a+b));


            Console.Read();

        }
    }
}
