using System;

namespace BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= -200 && firstNumber <= 200 && secondNumber >= -200 && secondNumber <= 200 && thirdNumber >= -200 && thirdNumber <= 200)
            {
                if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
                {
                    Console.WriteLine(firstNumber);
                }
                else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
                {
                    Console.WriteLine(secondNumber);
                }
                else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
                {
                    Console.WriteLine(thirdNumber);
                }
            }
        }
    }
}
