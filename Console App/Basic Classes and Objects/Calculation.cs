namespace ConsoleApp2
{
    public class Calculation
    {
        public string name = "Renith"; // this can be called by creating the instance of class
                                        // If we declare the class as static, then all the methods and variables must be static
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }   
        public static int Multiply(int a, int b)
        {
            return a * b;   
        }
        public static float Divide(float a, float b)
        {
            return a / b;
        }
    }
}
