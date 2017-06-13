using System;
using System.Numerics;

namespace BinaryToDecimel
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string inpuString = Console.ReadLine();
            int lenght = inpuString.Length;
            BigInteger binaryNumber = BigInteger.Parse(inpuString);
            BigInteger digit;
            BigInteger decimelNumber = 0;

            for (int i = 0; i < lenght; i++)
            {
                digit = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimelNumber = decimelNumber + digit * (BigInteger)Math.Pow(2, i);
            }

            Console.WriteLine(decimelNumber);
        }
    }
}
