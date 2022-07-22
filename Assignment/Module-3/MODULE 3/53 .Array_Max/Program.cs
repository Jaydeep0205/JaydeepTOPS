using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Array_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter Array Values : \n");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n Array Value : \n");
            foreach (var item in arr)
            {
                Console.Write("  "+item);
            }

            int Max = arr.Max();

            Console.WriteLine("\n\nMaximum Value Of Array  :  "+Max);

            Console.Read();
        }
    }
}
