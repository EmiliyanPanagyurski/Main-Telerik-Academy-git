using System;

namespace NumbersComparer
{
    class NumbersComparer
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            bool greatnum = firstNumber > secondNumber;

            switch (greatnum)
            {
                case false:
                    Console.WriteLine(secondNumber);
                    break;
                case true:
                    Console.WriteLine(firstNumber);
                    break;
            }
        }
    }
}
