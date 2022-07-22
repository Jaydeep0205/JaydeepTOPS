using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ASCII_Number
{
    //Show ASCII value of entered number
    class Program
    {
        static void Main(string[] args)
        {
            char J;
            Console.Write("Enter Any Character For ASCII Value : ");
            J = Convert.ToChar( Console.ReadLine());

            int n = Convert.ToInt32(J);

            Console.WriteLine("ASCII Value : {0}",n);



            Console.Read();
        }
    }
}
