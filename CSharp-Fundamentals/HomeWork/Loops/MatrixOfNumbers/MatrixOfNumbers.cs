using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write("{0} ", j + i);
                }

                Console.WriteLine();
            }
        }
    }
}
