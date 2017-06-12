using System;

namespace SumOfNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            double numberOfInputs = int.Parse(Console.ReadLine());
            double sum = 0;

            if (numberOfInputs >= 1 && numberOfInputs <= 200)
            {
                for (int i = 0; i < numberOfInputs; i++)
                {
                    double number = int.Parse(Console.ReadLine());
                    sum = sum + number;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
