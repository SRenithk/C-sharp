using System;
using Basic_Classes_and_Objects;
using BasicNonPrimitiveTypes;

namespace ConsoleApp2
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            //Main Method //the static Modifier which means, the class cannot be called by creating objects, it can be called by class ifself
            Person person = new Person(); //new Person() which allocates some memory
            person.Name = "Renith";
            person.Introduce();

            //Calculation by using class name and its static methods (directly calling from Class without creating objects for them)
            int add         = Calculation.Add(2,5);
            int sub         = Calculation.Subtract(6,3);
            int multiply    = Calculation.Multiply(3,5);
            float divide    = Calculation.Divide(7,3);
            Console.WriteLine("\nAddition:{0} \nSubtraction:{1} \nMultiplication:{2} \nDivision:{3}",add,sub,multiply,divide);

            //Now creating instance for Calculation class to access name field which is not static
            Calculation calc = new Calculation();
            Console.WriteLine(calc.name);
            //StringandArrays
            ArraysAndStrings arr = new ArraysAndStrings();
            arr.StringImplementation();

            //Implementation Enum
            Enums enumeration = new Enums();
            enumeration.ImplementEnum();

            //Implementation of reference types
            var text = "Hello";
            var text2 = text;
            var num = 2;
            var num2 = num;
            Console.WriteLine(text.GetHashCode());
            Console.WriteLine(text2.GetHashCode());
            Console.WriteLine(num.GetHashCode());
            Console.WriteLine(num2.GetHashCode());
        }
    }
}
