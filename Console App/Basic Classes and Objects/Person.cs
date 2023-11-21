namespace ConsoleApp2
{
    public class Person //When we create instance of this class, we can assign a name and call the Introduce method
    {
        public string Name;
        public void Introduce()
        {
            Console.WriteLine("Hello, My Name is " + Name);
        }
    }
}
