using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Clear();
            Console.Beep();
            Console.WriteLine("You Heard the Beap Sound");
            Person person = new Person("asas");
        }
    }
    class Person
    {
        public Person(string data)
        {
            Console.WriteLine(data);
            this.FormatStrings_PlaceHolders();
        }
        public void FormatStrings_PlaceHolders()
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        }
    }
}
