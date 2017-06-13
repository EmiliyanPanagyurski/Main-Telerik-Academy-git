using System;

namespace NumbersFromOneToN
{
    class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Console.Write("1");
            for (int index = 2; index <= inputNumber; index++)
            {
                Console.Write(" {0}", index);
            }

            Console.WriteLine();
        }
    }
}
