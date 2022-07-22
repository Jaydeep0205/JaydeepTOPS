using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Marksheet
{
    //Write a program to get three subject marks details and then show average and sum.
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] sub = new int[3];
            Console.WriteLine(" ------ Student Marksheet ------ \n");

            Console.WriteLine("Student Name : Jaydeep \n");
            Console.WriteLine("Class : C# \n");

            Console.WriteLine("\nEnter Subjects Marks Out Of 100 : \n");

            for (int i = 0; i < sub.Length; i++)
            {
                Console.Write("Subject-{0} :  ",i+1);
                sub[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < sub.Length; i++)
            {
                sum = sum + sub[i];
            }

            Console.WriteLine("\nTotal Marks : {0} Out Of 300",sum);
            Console.WriteLine("\nAverage Marks : {0}",sum/3);


            Console.Read();
        }
    }
}
