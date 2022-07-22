using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Assignment_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Patterns-------");
            Console.WriteLine("-- a --");
            int n = 4;
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0} ", k++);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-- b --");
            int N = 5;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-- c --");

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("# ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-- d --");

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-- e --");

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-- f --");

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
