using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.Multilevel_Inheritence
{
    class Parent
    {
        internal int a;
        internal void SetA()
        {
            Console.Write("\n\nEnter Value of A : ");
            a = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Child : Parent
    {
        internal int b;
        internal void SetB()
        {
            SetA();
            Console.Write("\n\nEnter Value of B : ");
            b = Convert.ToInt32(Console.ReadLine());

        }
    }

    class SubChild : Child
    {
        internal void GetAB()
        {
            SetB();
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
