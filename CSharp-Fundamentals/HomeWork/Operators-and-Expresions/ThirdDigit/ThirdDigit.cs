using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int input = Int32.Parse(Console.ReadLine());
            input = (input / 100) % 10;
            if (input == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", input);
            }
        }
    }
}