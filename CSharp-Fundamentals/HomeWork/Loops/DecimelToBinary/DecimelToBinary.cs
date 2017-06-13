using System;

namespace DecimelToBinary
{
    class DecimelToBinary
    {
        static void Main()
        {
            long decimelNumber = long.Parse(Console.ReadLine());
            string binaryNumber = "";
            string temporaryString;

            while (decimelNumber != 1)
            {
                long digit = decimelNumber % 2;
                temporaryString = digit.ToString();
                binaryNumber = temporaryString + binaryNumber;
                decimelNumber = decimelNumber / 2;
            }

            temporaryString = decimelNumber.ToString();
            binaryNumber = temporaryString + binaryNumber;

            Console.WriteLine(binaryNumber);
        }
    }
}
