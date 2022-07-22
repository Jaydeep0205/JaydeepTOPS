using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Transpose_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c;

            int[,] arr = new int[10, 10];

            Console.WriteLine("Array matrix.....");

            Console.Write("Enter the row of Matrix : ");
            r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the column of Matrix is: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter Array element...");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }


            Console.WriteLine("\n\nMatrix Array Elements Are ...");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("  " + arr[i, j]);
                }
                Console.WriteLine();

            }


            Console.WriteLine("\n\nTranspose Matrix Array Elements Are ...");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("  " + arr[j, i]);
                }
                Console.WriteLine();

            }

            Console.Read();

        }
    }
}
