using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.Char_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Jaydiep";

            s = s.Replace('i', 'e');

            Console.WriteLine("New String : " + s);

            Console.Read();
        }
    }
}
