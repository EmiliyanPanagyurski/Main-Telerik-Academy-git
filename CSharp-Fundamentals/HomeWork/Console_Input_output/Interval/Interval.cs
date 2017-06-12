using System;

namespace Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int index = 0;

            if (firstNumber >= 0 && firstNumber <= secondNumber && secondNumber <= 2000)
            {
                for (int j = firstNumber + 1; j < secondNumber; j++)
                    if (j % 5 == 0)
                    {
                        index++;
                    }

                Console.WriteLine(index); ;
            }
        }
    }
}
