using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];

            arr[0] = new int[] { 2, 5, 6, 9 };
            arr[1] = new int[] { 1, 9,6,3,0,8,6 };
            arr[2] = new int[] { 9, 5 };
            arr[3] = new int[] { 0,9,6,3,5,8 };


            Console.WriteLine("\n..... Jagged Array ..... \n");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" "+arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.Read();
                
               
        }
    }
}
