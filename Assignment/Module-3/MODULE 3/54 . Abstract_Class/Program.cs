using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54.Abstract_Class
{
    abstract class Base
    {
        int a, b;
        virtual internal void Set(int a, int b)
        {

        }
        virtual internal void GetData()
        {
        }
        virtual internal void DisplayData()
        {
        }


    }

    class Derived : Base
    {
        int a, b;
        override internal void Set(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        internal override void GetData()
        {
            Console.WriteLine("Value A : " + a);
            Console.WriteLine("Value B : " + b);
        }

        internal override void DisplayData()
        {
            Console.WriteLine("Subtraction Of A - B : {0}", a - b);
        }



    }





    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Derived();
            b.Set(12, 7);
            b.GetData();
            b.DisplayData();

            Console.Read();
        }
    }
}
