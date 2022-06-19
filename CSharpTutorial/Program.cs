using Angie_CSharpTutorial.Inheritance;
using Angie_CSharpTutorial.Modifiers2;
using Angie_CSharpTutorial.Partial_Class;
using CSharpTutorial.Modifiers;
using InheritancePartialClass.Polymorphism;
using InheritancePartialClass.Polymorphism.Operator_Overloading;
using InheritancePartialClass.Polymorphism.DynamicPolymorphism;
using System;

namespace CSharpTutorial
{
    public class Program
    {
        public static void Main()
        {
            //Employee empl = new Employee();
            //empl.SetEmployeeDetails();
            //Employee.SetEmployeeDetails();
            //Person.SetPersonDetails();

            //Inheritance inherit = new Inheritance();
            //inherit.InheritanceDemo();

            //CalcuOperator obj = new CalcuOperator();
            //obj.Calculator(7, 5);

            //FunctionOverloading.DisplayOutput("angie", 23);
            //FunctionOverloading.DisplayOutput(23, 23);

            //OperationOverloading.OperatorOverloading();

            DynamicPolymorphism obj = new DynamicPolymorphism();
            obj.DisplayAnimalInfo();
        }
    }
}