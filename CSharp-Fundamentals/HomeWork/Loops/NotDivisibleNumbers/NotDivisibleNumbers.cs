using System;

namespace NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int temporaryValue, secondTemporaryValue;
            if (inputNumber >= 1 && inputNumber <= 1500)
            {
                Console.Write("1");
                for (int index = 2; index <= inputNumber; index++)
                {
                    temporaryValue = index % 3;
                    secondTemporaryValue = index % 7;
                    if (temporaryValue != 0 && secondTemporaryValue != 0)
                    {
                        Console.Write(" {0}", index);
                    }
                }
            }
        }
    }
}
