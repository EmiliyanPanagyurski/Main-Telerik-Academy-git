using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int input = Int32.Parse(Console.ReadLine());

            int firstDigit = (input / 1000) % 10;
            int secondDigit = (input / 100) % 10;
            int thirdDigit = (input / 10) % 10;
            int fourthDigit = input % 10;

            Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
    }
}