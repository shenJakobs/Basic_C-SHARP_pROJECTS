using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssingment
{
    public class Employee : IQuittable 
    {
        // Properties
        public string Name { get; set; }
        public int EmployeeID { get; set; }

        // Constructor
        public Employee(string name, int employeeID)
        {
            Name = name;
            EmployeeID = employeeID;
        }

        public Employee(string v)
        {
        }

        // Method
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeID}");
        }
        public void Quit()
        {
            Console.WriteLine($"{Name} has quit the job.");
        }
    }

}

