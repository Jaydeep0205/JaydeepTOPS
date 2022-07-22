using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Call_Parent_Class
{
    class Parent
    {
        protected int x, y;
        internal void SetValue()
        {
            x = 20;
            y = 10;
            Console.WriteLine("\nThis Is Parent Class Calling ...........\n");
            Console.WriteLine("\tValue of X : {0}",x);
            Console.WriteLine("\tValue of Y : {0}",y);
        }

    }

    class Child : Parent
    {
        internal void Display()
        {
            Console.WriteLine("\n\nThis Is From Child Class.......");
            Console.WriteLine("\nAddition Of Values {0} + {1} : {2}",x,y,x+y);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.SetValue();
            c.Display();

            Console.Read();
        }
    }
}
