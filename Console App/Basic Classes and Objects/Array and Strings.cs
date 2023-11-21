using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNonPrimitiveTypes
{
    internal class ArraysAndStrings
    {
        public void StringImplementation()
        {
            //instead of declaring 3 number variables
            //we can

            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //public void Assign() //instead of assigning values in the below way
            //we can assign while initilization itself
            //{
            //    numbers[0] = 1 ;
            //    numbers[1] = 1 ;
            //}

            //Strings
            string firstName = "Renith"; //string literal //string keyword
            String lastName = "Kumar";      //string from System class

            var fullName = firstName + " " + lastName;
            //or //string.Format
            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);
            //string.Join
            string[] names = new string[3] { "Renith", "Kumar", "Senthil" };
            string myJoinedName = string.Join(".", names);

            Console.WriteLine(myJoinedName);

            //Verbatim strings
            string path = "Hi Renith \nlook into path \nc:\\projects\\project1\\folder1";
            string paths = @"Hi Renith
look into path
c:\projects\project1\folder1";
            Console.WriteLine(path);
            Console.WriteLine("\n");
            Console.WriteLine(paths);
        }
    }
}
