using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.Class_Abstract
{

    abstract class Base
    {
        int a, b;
        virtual internal void Get(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        virtual internal void Display()
        {
            Console.WriteLine(" Value of A : " + a);
            Console.WriteLine(" Value of B : " + b);
            Console.WriteLine("Addition : {0} ", a + b);
        }

    }

    class Derived : Base
    {
        int a, b;
        override internal void Get(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        override internal void Display()
        {
            Console.WriteLine(" Value of A : " + a);
            Console.WriteLine(" Value of B : " + b);
            Console.WriteLine(" Addition : {0} ", a + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.Get(12, 5);
            d.Display();
            

            Console.Read();
        }
    }
}
