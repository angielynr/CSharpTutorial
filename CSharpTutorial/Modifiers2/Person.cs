using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angie_CSharpTutorial.Modifiers2
{
    internal class Person
    {

        //Constructor

        public Person(string fullName, int age, string job)
        {
            var defaultPerson = new PersonDetails()
            {
                Name = fullName,
                age = age,
                job = job
            };
            Console.WriteLine(fullName + age + job);
        }
        public void DisplayPersonDetails(PersonDetails persondetails)
        {
            Console.WriteLine($"Person Details: {persondetails.Name}");
            Console.WriteLine($"Person Details: {persondetails.age}");
            Console.WriteLine($"Person Details: {persondetails.job}");
        }
        
        public static void SetPersonDetails()
        {
            var person1 = new PersonDetails()
            {
                Name = "angie rivera",
                age = 23,
                job = ".Net Developer"
            };
            
            var person2 = new PersonDetails()
            {
                Name = "Maggie rivera",
                age = 2,
                job = "Stress reliever"
            };

            Person displayDetails = new Person("anjsf", 2, "dfdsf");
            displayDetails.DisplayPersonDetails(person1);
            displayDetails.DisplayPersonDetails(person2);
        }
    }
}
