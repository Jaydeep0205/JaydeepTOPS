using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Constructor
{
    class Parent
    {
        public Parent()
        {
            int[] arr = new int[10];

            Console.WriteLine("\nEnter Array Value : ");
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
             Array.Sort(arr);
            Console.WriteLine("\n\nArray In Ascdending Order\n\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("  {0}",arr[i]);
            }
        }


    }
   

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();

            Console.Read();
        }
    }
}
