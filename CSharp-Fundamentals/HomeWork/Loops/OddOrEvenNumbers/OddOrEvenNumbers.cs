using System;

namespace OddOrEvenNumbers
{
    class OddOrEvenNumbers
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            string numbersString = Console.ReadLine();
            string[] numbers = numbersString.Split(' ');
            long odd = 1;
            long even = 1;

            for (int index = 1; index <= numbersCount; index++)
            {
                if (index % 2 == 0)
                {
                    even = even * int.Parse(numbers[index - 1]);
                }
                else
                {
                    odd = odd * int.Parse(numbers[index - 1]);
                }
            }

            if (odd == even)
            {
                Console.WriteLine("yes {0}", even);
            }
            else
            {
                Console.WriteLine("no {0} {1}", odd, even);
            }
        }
    }
}
