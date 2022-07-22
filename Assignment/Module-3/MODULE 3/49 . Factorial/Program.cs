using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.Factorial
{
    class Factorial
    {
        int n;
        int fact = 1;
        internal void SetData()
        {
            Console.Write("Enter Number For Factorial : ");
            n = Convert.ToInt32(Console.ReadLine());
        }

        internal void DisplayData()
        {
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of {0} : {1}", n, fact);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Factorial F = new Factorial();
            F.SetData();
            F.DisplayData();

            Console.Read();
        }
    }
}
