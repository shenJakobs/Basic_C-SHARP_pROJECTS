using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssingment
{


    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations math = new MathOperations();

            // Call the PerformOperation method with two numbers
            math.PerformOperation(5,10);

            // Call the PerformOperation method
            math.PerformOperation(firstNumber: 10, secondNumber: 20);

            Console.ReadLine();
        }
    }
}


