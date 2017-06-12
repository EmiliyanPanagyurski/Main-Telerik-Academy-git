using System;

namespace DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int inputAsNumber = Int32.Parse(input);

            if (inputAsNumber % 7 == 0 && inputAsNumber % 5 == 0)
            {
                Console.WriteLine("true {0}", inputAsNumber);
            }
            else
            {
                Console.WriteLine("false {0}", inputAsNumber);
            }

        }
    }
}
