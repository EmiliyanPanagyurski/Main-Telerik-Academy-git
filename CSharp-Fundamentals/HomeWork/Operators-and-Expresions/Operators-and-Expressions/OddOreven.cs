using System;

namespace OddorEven
{
    class OddorEven
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int inputAsNumber = Int32.Parse(input);

            if (inputAsNumber % 2 == 0)
            {
                Console.WriteLine("even " + inputAsNumber);
            }
            else
            {
                Console.WriteLine("odd " + inputAsNumber);
            }
        }
    }
}