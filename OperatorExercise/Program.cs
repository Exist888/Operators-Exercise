namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Declare and Initialize Two Variables
            int a = 17;
            int b = 4;
            
            //Perform Arithmetic Operations
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            
            //Display the Results Using String Interpolation
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            
            //Exercise 2 - Prompt, Input, Call, and Output
            Console.WriteLine("Enter the radius of a circle:");
            double radius = double.Parse(Console.ReadLine());
            double answer = AreaOfCircle(radius);
            Console.WriteLine($"A circle with a radius of {radius} will have an area of {answer}.");

        }
        
        //Define the AreaOfCircle
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
    }
}
