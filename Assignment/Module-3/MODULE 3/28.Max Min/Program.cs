using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Max_Min
{
    class Value
    {
        int[] arr = new int[3];
        internal void SetValue()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter value {0} : ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        internal void GetValue()
        {
            Console.WriteLine("\nMaximum Value : {0}", arr.Max());
            Console.WriteLine("\nMinimum Value : {0}", arr.Min());

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Value v = new Value();
            v.SetValue();
            v.GetValue();


            Console.Read();
        }
    }
}


