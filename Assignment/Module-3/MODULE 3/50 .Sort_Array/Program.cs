using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 9, 6, 9, 2 };

            Array.Sort(arr);

            Console.WriteLine("Array In Ascending Order \n");

            foreach (var item in arr)
            {
                Console.WriteLine("\t " + item);
            }


            Array.Reverse(arr);

            Console.WriteLine("\nArray in Revesres order \n");

            foreach (var item in arr)
            {
                Console.WriteLine("\t " + item);
            }

            Console.Read();

        }
    }
}
