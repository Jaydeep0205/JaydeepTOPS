using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Dictionariesssss
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> D = new Dictionary<string, object>();
            D.Add("Student Name ", "Jaydeep");
            D.Add("Age\t", 26);
            D.Add("Qaulification ", "B.E Mechanical");
            D.Add("Passing Year ", 2017);
            D.Add("Department", "IT");
            D.Add("Course", ".Net MVC");

            foreach (var item in D)
            {
                Console.WriteLine(item.Key + "\t : " + item.Value);
            }
            Console.Read();
        }
    }
}
