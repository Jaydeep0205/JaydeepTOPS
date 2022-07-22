using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Array_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "Array ", "String",
                                          "Stack ", "Queue ",
                                          "Exception ", "Operators","Interface" };

            string[] Sec = new string[] { "J-200", "J-500", "J-800", "J-900", "J-300", "J-700" };

          
            Console.WriteLine("-----String Array -----\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\t" + arr[i]);
            }

            Array.Sort(arr);
            Console.WriteLine("\n  ----- Array In Ascending Order -----\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\t" + arr[i]);
            }

            Array.Reverse(arr);

            Console.WriteLine("\n  -----Array In Reverse Order-----\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\t" + arr[i]);
            }
             
            Console.WriteLine("\n----- Second String Array-----\n");
            for (int i = 0; i < Sec.Length; i++)
            {
                Console.WriteLine("\t" + Sec[i]);
            }



            Array.Copy(Sec, arr, 3);

            Console.WriteLine("\n----- Array After Copying First 3 String of Second Array-----\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\t" + arr[i]);
            }
            

            Console.Read();
        }
    }
}
