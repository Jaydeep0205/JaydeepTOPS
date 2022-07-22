using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.String_Iterate_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] companies = new string[4] { "Google", "Apple", "Amazon", "Microsoft" };

            foreach (string company in companies)
            {
                Console.WriteLine(company);
            }

            Console.Read();
        }
    }
}
