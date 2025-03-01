using System.Xml.Linq;

namespace MethodsExercise
{ 
    public class Mathamatics
    {
        public int Sum(int[] args)
        {
            int sum = 0;
            foreach (int number in args) {
                sum += number;
            }
            return sum;
        }

        public int Subtract(int one, int two)
        {
            
            return one - two;
        }

        public int Multiply(int one, int two)
        {
            return one * two;
        }

        public double Devide(int one, int two)
        {
            return (double)one / two;
        }
    }
    public class Program
    {
        static void Story()
        {
            Console.WriteLine("Enter your name!");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter your dogs name!");
            string? dog = Console.ReadLine();
            Console.WriteLine($"{name} has a really cute dog named {dog} however my dog Ozzy is cuter (Picture provided in source code for proof)");
        }


        static void Main(string[] args)
        {
            // Show the math
            Mathamatics math = new Mathamatics();

            int sum = math.Sum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine($"sum: {sum}");
            int sub = math.Subtract(1,3);
            Console.WriteLine($"subtract: {sub}");
            int quotent = math.Multiply(2, 4);
            Console.WriteLine($"multiply: {quotent}");
            double dontKnowTheWord = math.Devide(3, 2);
            Console.WriteLine($"devide: {dontKnowTheWord}\n");

            // Do the story
            Story();

        }
    }
}
