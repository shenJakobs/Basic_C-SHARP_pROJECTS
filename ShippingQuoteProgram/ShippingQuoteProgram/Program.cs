using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. to Calculate your Shipping ");

            // package weight 
            Console.Write("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            // if weight is over limit 
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped, Have a good day");
                Console.ReadLine(); 
            }
            else
            {
                // Get package dimensions from user
                Console.Write("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                // find total dimensions
                int totalDimensions = width + height + length;

                // see if dimensions total exceeds limit
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    // Calculate shipping quote
                    int quote = (width * height * length * weight) / 100;

                    // Display shipping quote to the user
                    Console.WriteLine("Your estimated total for shipping this package is:$" + quote + ".00");
                    Console.WriteLine("Thank you");
                    Console.ReadLine();
                }
            }
        }
    }
}


