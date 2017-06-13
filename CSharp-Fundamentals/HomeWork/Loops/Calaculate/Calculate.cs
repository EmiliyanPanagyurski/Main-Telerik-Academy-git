using System;

namespace Calaculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double result = 1;

            if (n >= 2 && n <= 10 && x >= 0.5 && x <= 100)
            {
                for (int index = 1; index <= n; index++)
                {
                    result += (Calculate.Factorial(index)) / (Math.Pow(x, index));
                }

                Console.WriteLine("{0:F5}", result);
            }
        }

        static int Factorial(int number)
        {
            if (number <= 1)
                return 1;
            return number * Factorial(number - 1);
        }
    }
}
