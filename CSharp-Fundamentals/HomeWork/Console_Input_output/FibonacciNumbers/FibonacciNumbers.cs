using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            long fibNumber = long.Parse(Console.ReadLine());
            long[] fib;
            fib = new long[fibNumber + 1];
            fib[0] = 0;
            fib[1] = 1;

            if (fibNumber >= 1 && fibNumber <= 50)
            {
                for (long i = 2; i < fibNumber; i++)
                {
                    fib[i] = fib[i - 2] + fib[i - 1];
                }

                Console.Write(fib[0]);

                for (int i = 1; i < fibNumber; i++)
                {
                    Console.Write(", {0}", fib[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
