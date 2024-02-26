using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssingment
{
    public class MathOperations
    {
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = secondNumber - firstNumber;

            Console.WriteLine($"{firstNumber} + 10 = {secondNumber}");
        }
    }
}
