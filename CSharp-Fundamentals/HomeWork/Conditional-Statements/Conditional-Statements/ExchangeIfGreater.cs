using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double firstInput = double.Parse(Console.ReadLine());
            double secondInput = double.Parse(Console.ReadLine());

            if (firstInput >= -100 && firstInput <= 100 && secondInput >= -100 && secondInput <= 100)
            {
                if (firstInput > secondInput)
                {
                    double temporaryValue = firstInput;
                    firstInput = secondInput;
                    secondInput = temporaryValue;
                }

                Console.WriteLine("{0} {1}", firstInput, secondInput);
            }
        }
    }
}
