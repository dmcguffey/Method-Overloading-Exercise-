using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;
            if (isTrue == true && sum > 1)
            {
                return ($"{sum} dollars");
            }
            else if (isTrue == true && sum <= 1)
            {
                return ($"{sum} dollar");
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("x is:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("y is: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Add(4.0m, 5.78m));
            Console.WriteLine(Add(x, y, true));

        }
    }
}
