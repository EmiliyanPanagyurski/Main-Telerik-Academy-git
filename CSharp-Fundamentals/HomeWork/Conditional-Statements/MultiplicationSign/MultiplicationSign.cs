using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double temporaryValue;
            int negativeValueCount = 0;

            for(int index = 0; index < 3; index++)
            {
                temporaryValue = double.Parse(Console.ReadLine());

                if(temporaryValue == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
                else if(negativeValueCount > 0)
                {
                    continue;
                }
                else if(negativeValueCount < 0)
                {
                    negativeValueCount++;
                }
            }

            if(negativeValueCount % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
