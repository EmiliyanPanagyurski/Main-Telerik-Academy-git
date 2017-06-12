using System;

namespace Console_Input_output
{
    class SumOfThreeNumbers
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber <= 1000 && firstNumber >= -1000 && secondNumber >= -1000 && secondNumber <= 1000 && thirdNumber >= -1000 && thirdNumber <= 1000)
            {
                double sum = firstNumber + secondNumber + thirdNumber;
                Console.WriteLine(sum);
            }
        }
    }
}
