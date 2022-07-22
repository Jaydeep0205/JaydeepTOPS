using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Array_Addition
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];


            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter value {0} : ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\nArray Values : \n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }

            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("\n\nAddition of Array Values : {0}",sum);



            Console.Read();
        }
    }
}
