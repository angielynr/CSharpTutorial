using Angie_CSharpTutorial.Inheritance;
using Angie_CSharpTutorial.Modifiers2;
using Angie_CSharpTutorial.Partial_Class;
using CSharpTutorial.Modifiers;
using System;

namespace CSharpTutorial
{
    public class Program
    {
        public static void Main()
        {
            /*Employee empl = new Employee();
            empl.SetEmployeeDetails();*/
            //Employee.SetEmployeeDetails();
            //Person.SetPersonDetails();

            //Inheritance inherit = new Inheritance();
            //inherit.InheritanceDemo();

            CalcuOperator obj = new CalcuOperator();
            obj.Calculator(7, 5);
        }
    }
}