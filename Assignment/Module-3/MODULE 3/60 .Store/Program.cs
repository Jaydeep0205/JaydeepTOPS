using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.Store
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] Prod_Name = new string[3];
            double[] Price = new double[3];
            int[] qty = new int[3];
            double[] amt = new double[3];
            double amount = 0;



            Console.WriteLine("\n\tWelcome To A To Z Store\n\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nEnter Product Name : ");
                Prod_Name[i] = Console.ReadLine();

                Console.Write("\nProduct Price : ");
                Price[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nQuantity : ");
                qty[i] = Convert.ToInt32(Console.ReadLine());

                amt[i] = Price[i] * qty[i];
                amount = amount + amt[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\n\nProduct Name : {Prod_Name[i]} \tPrice : {Price[i]} \tQty. : {qty[i]} \tAmount : {amt[i]} ");
            }
            Console.WriteLine("\n\nFinal Bill Amount : "+amount);


            Console.Read();

        }
    }
}
