using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Implicit___Explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;

            Console.WriteLine("This Is Implicit ");
            Console.WriteLine("A : "+a);
            object b = a;
            Console.WriteLine("B : {0}\n\n", b);
            // Here Value of " a " is in String Type After Conversion is Called Implicit
            // Here Value of " b " is in Object Type After Conversion is Called Implicit
            Console.WriteLine();

            string s = "102";

            int d = Convert.ToInt32(s);
            Console.WriteLine("This Is Explicit ");
            Console.WriteLine("D : {0}",d);
            // Here Value Of  "d" is in INT Type After Conversion is Called Explicit

            Console.Read();
        }
    }
}
