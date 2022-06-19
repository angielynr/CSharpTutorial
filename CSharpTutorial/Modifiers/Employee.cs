using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.Modifiers
{
    internal class Employee
    {
        //Constructor
        public Employee(string firstName, string lastName)
        {
            var emp1Cons = new EmployeeDetails()
            {
                FirstName = firstName,
                LastName = lastName
            };
            Console.WriteLine($"Default {firstName} {lastName}");
        }

        public void DisplayEmployeeDetails(EmployeeDetails employee)
        {
            Console.WriteLine($"Employee Detais: {employee.FirstName}");
            Console.WriteLine($"Employee Detais: {employee.LastName}");
        }

        public static void SetEmployeeDetails()
        {

            var emp1 = new EmployeeDetails()
            {
                FirstName = "Angie",
                LastName = "Rivera"
            };
            var emp2 = new EmployeeDetails()
            {
                FirstName = "Maggie",
                LastName = "Loa"
            };

            Employee empDetails = new Employee("dsfd", "dfdsf");
            empDetails.DisplayEmployeeDetails(emp1);
            empDetails.DisplayEmployeeDetails(emp2);
        }
    }
}
