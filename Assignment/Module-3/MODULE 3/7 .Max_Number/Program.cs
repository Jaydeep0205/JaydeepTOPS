using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter Value of A : ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Value of B : ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("\n{0} is Maximum Number than {1}",a,b);
            }
            else
            {
                Console.WriteLine("\n{0} is Maximum Number than {1}",b,a);
            }

            Console.Read();
        }
    }
}
