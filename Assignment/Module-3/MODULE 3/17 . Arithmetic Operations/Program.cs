using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Arithmetic_Operations
{
    class Arithmetic
    {
        int x, y;
        int Ans;

        internal void SetData()
        {
            Console.Write("\nEnter Value Of X : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Value Of Y : ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        internal void Operation()
        {
            Console.WriteLine("\n\n--------Arithmetic Operations--------");
            Console.WriteLine("\n\nOperations On Value {0} And {1}", x, y);

            Ans = x + y;
            Console.WriteLine("\n\nAdditional Operation : {0}", Ans);

            Ans = x - y;
            Console.WriteLine("\nSubstraction Operation : {0}", Ans);

            Ans = x * y;
            Console.WriteLine("\nMultiplication Operation : {0}", Ans);

            Ans = x / y;
            Console.WriteLine("\nDivision Operation : {0}", Ans);

            Ans = x % y;
            Console.WriteLine("\nModule Operation : {0}", Ans);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Arithmetic A = new Arithmetic();
                A.SetData();
                A.Operation();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
