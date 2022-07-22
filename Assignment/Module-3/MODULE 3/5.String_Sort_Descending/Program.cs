using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.String_Sort_Descending
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "Cook", "Zebra", "JQuery", "D#", "Kotlin", "Nodejs" };

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\t {0}\n",arr[i]);
            }
               
            Console.Read();
        }
    }
}
