using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            if (inputString == "1" || inputString == "2" || inputString == "3" || inputString == "4" || inputString == "5" || inputString == "6" || inputString == "7" || inputString == "8" || inputString == "9" || inputString == "10" || inputString == "J" || inputString == "Q" || inputString == "K" || inputString == "inputString")
            {
                Console.WriteLine("yes {0}", inputString);
            }
            else
            {
                Console.WriteLine("no {0}", inputString);
            }
        }
    }
}
