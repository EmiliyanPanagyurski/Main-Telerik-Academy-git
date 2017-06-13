using System;

namespace MMSA
{
    class MMSA
    {
        static void Main()
        {
            double min, max;
            double sum = 0;
            double avg;
            int inputNumber = int.Parse(Console.ReadLine());
            double[] numbersArray = new double[inputNumber];

            if (inputNumber >= 1 && inputNumber <= 1000)
            {
                for (int index = 0; index <= inputNumber - 1; index++)
                {
                    numbersArray[index] = double.Parse(Console.ReadLine());
                }

                min = numbersArray[0];
                for (int index = 1; index <= inputNumber - 1; index++)
                {
                    if (numbersArray[index] < min)
                    {
                        min = numbersArray[index];
                    }
                }

                max = numbersArray[0];
                for (int index = 1; index <= inputNumber - 1; index++)
                {
                    if (numbersArray[index] > max)
                    {
                        max = numbersArray[index];
                    }
                }

                for (int index = 0; index <= inputNumber - 1; index++)
                {
                    sum = sum + numbersArray[index];
                }

                avg = sum / inputNumber;

                Console.WriteLine("min={0:0.00}", min);
                Console.WriteLine("max={0:0.00}", max);
                Console.WriteLine("sum={0:0.00}", sum);
                Console.WriteLine("avg={0:0.00}", avg);
            }
        }
    }
}
