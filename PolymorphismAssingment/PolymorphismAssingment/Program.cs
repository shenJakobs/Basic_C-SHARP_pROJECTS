using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssingment
{
    class Program
    {
 
            static void Main(string[] args)
            {
                // Create an object of type IQuittable
                Employee employee = new Employee("JOHN DOE, 1001"); // Create an Employee object using the default constructor

                // Set the Name and EmployeeID properties separately
                employee.Name = "John Doe";
                employee.EmployeeID = 1001;


                // Call the Quit method using the IQuittable reference
                employee.Quit();

            Console.ReadLine();
            }
        }

    }

