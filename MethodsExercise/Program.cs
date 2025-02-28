using System.Xml.Linq;

namespace MethodsExercise
{ 
    public class mathamatics
    {
        public int sum(int[] args)
        {
            int sum = 0;
            foreach (int number in args) {
                sum += number;
            }
            return sum;
        }

        public int subtract(int one, int two)
        {
            
            return one - two;
        }

        public int multiply(int one, int two)
        {
            return one * two;
        }

        public double devide(int one, int two)
        {
            return (double)one / two;
        }
    }
    public class Program
    {
        static void story()
        {
            Console.WriteLine("Enter your name!");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter your dogs name!");
            string? dog = Console.ReadLine();
            Console.WriteLine($"{name} has a really cute dog named {dog} however my dog Ozzy is cuter (Picture provided in source code for proof)");
        }


        static void Main(string[] args)
        {
            mathamatics math = new mathamatics();

            int sum = math.sum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine($"sum: {sum}");
            int sub = math.subtract(1,3);
            Console.WriteLine($"subtract: {sub}");
            int quotent = math.multiply(2, 4);
            Console.WriteLine($"multiply: {quotent}");
            double dontKnowTheWord = math.devide(3, 2);
            Console.WriteLine($"devide: {dontKnowTheWord}");

            story();

        }
    }
}
