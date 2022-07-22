using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- a ---");
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= 0; j++)
                {
                    Console.Write(i * i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- b ---");
            int a = 1, b = 1, c;
            Console.WriteLine("{0}\n{1}", a, b);

            for (int i = 1; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }

            Console.WriteLine("\n--- c ---");
            int m = 0;

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("{0}", (i * i) + m);
                m = i * i + m;

            }

            Console.Read();

        }
    }
}
