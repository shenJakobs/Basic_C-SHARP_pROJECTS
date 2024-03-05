using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate
            Employee emp1 = new Employee(1, "John", "Doe");
            Employee emp2 = new Employee(1, "Jane", "Smith");

            // overloaded operators
            bool equal = emp1 == emp2;
            bool notEqual = emp1 != emp2;

            // results
            Console.WriteLine("Comparison result using overloaded operators:");
            Console.WriteLine($"emp1 == emp2: {equal}"); // Should be true
            Console.WriteLine($"emp1 != emp2: {notEqual}"); // Should be false

            
            Console.ReadLine();
        }
    }
}
