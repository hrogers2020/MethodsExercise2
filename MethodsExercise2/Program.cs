using System;

namespace MethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to add to the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number to multiply");
                int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply with the previous number");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The product is: {product}");

        }
        public static int Sum(int num1, int num2)
        {
            //int sum = num1 + num2;

            //return sum;

            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
