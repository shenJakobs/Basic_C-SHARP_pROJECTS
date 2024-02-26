using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // This  is addition
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            // This  is Subtraction 
            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //This is Multiplication
            //int Product = 10 * 5;
            //Console.WriteLine(Product);
            //Console.ReadLine();

            // This is divison 
            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            // This is remainders 
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            // This is the Compairison operator 
            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();


            int roomTemp = 70;
            int currentTemp = 68;
            // bool isWarm = currentTemp >= roomTemp; this is greater than or equal to operator 
            bool isWarm = currentTemp == roomTemp; // Checks for equality 
            Console.WriteLine(isWarm);
            Console.ReadLine(); 

        }
    }
}
