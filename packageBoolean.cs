using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Enter your package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a nice day");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter package width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter package height: ");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter package length: ");
                decimal lenght = Convert.ToDecimal(Console.ReadLine());

                decimal dimensions = (width * height * lenght);
                if (dimensions > 5000)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a nice day");
                    Console.ReadLine();
                }
                else
                {
                    decimal total = dimensions * weight / 100;
                    Console.WriteLine("Your shipping quote is: " + string.Format("{0:C}", total) + ("\nThank you."));
                    Console.ReadLine();
                }
            }
               
        
            

        }
    }
}
