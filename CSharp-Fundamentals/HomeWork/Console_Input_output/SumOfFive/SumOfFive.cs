using System;

namespace SumOfFive
{
    class SumOfFive
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int result = 0;

            for(int index = 0; index < 5; index++)
            {
                numbers[index] = int.Parse(Console.ReadLine());
                result += numbers[index]; 
            }

            Console.WriteLine(result);
        }
    }
}
