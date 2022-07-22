using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Inheritance
{
    class Parent
    {
        protected int a;
        internal void SetA()
        {
            Console.Write("\n\nEnter Value of A : ");
            a = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Child : Parent
    {
        protected int b;
        internal void SetB()
        {

            Console.Write("\n\nEnter Value of B : ");
            b = Convert.ToInt32(Console.ReadLine());

        }
    }

    class SubChild : Child
    {
        internal void GetAB()
        {

            Console.WriteLine("\nAddition Of {0} + {1} : {2}", a, b, a + b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SubChild s = new SubChild();
                s.SetA();
                s.SetB();
                s.GetAB();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Read();
        }
    }
}
