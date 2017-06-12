namespace MythicalNumbers
{
    using System;

    class Mythical
    {
        static void Main()
        {
            string number = Console.ReadLine();
            double result = 0;
            double[] arrayDigits = new double[3];

            for (int index = 0; index < 3; index++)
            {
                string digit = Convert.ToString(number[index]);
                arrayDigits[index] = double.Parse(digit);
            }

            
            if (arrayDigits[2] == 0)
            {
                result = arrayDigits[1] * arrayDigits[0];
                Console.WriteLine("{0:F2}", result);
            }
            else if(arrayDigits[2]>0 && arrayDigits[2] <= 5)
            {
                result = (arrayDigits[1] * arrayDigits[0]) / arrayDigits[2];
                Console.WriteLine("{0:F2}", result);
            }
            else if (arrayDigits[2] > 5)
            {
                result = (arrayDigits[1] + arrayDigits[0]) * arrayDigits[2];
                Console.WriteLine("{0:F2}", result);
            }
            
        }
    }
}
