using System;

namespace PrintDeck
{
    class PrintDeck
    {
        static void Main()
        {
            string inputString = Console.ReadLine();

            switch (inputString)
            {
                case "2":
                    Console.WriteLine("2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds");
                    break;
                case "3":
                    for (int index = 2; index < 4; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    break;
                case "4":
                    for (int index = 2; index < 5; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    break;
                case "5":
                    for (int index = 2; index < 6; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    break;
                case "6":
                    for (int index = 2; index < 7; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    break;
                case "7":
                    for (int index = 2; index < 8; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    break;
                case "8":
                    for (int index = 2; index < 9; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    break;
                case "9":
                    for (int index = 2; index < 10; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    break;
                case "10":
                    for (int index = 2; index < 11; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    break;
                case "J":
                    for (int index = 2; index < 11; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    break;
                case "Q":
                    for (int index = 2; index < 11; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    break;
                case "K":
                    for (int index = 2; index < 11; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    break;
                case "A":
                    for (int index = 2; index < 11; index++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", index);
                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                    break;
                default:

                    break;

            }
        }
    }
}
