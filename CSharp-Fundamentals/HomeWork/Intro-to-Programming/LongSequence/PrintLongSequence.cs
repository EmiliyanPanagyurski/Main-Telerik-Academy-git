using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int firstMember = 2;
            int secondMemeber = -3;

            Console.WriteLine(firstMember);
            Console.WriteLine(secondMemeber);

            for (int index = 3; index <= 1000; index++)
            {
                if ((index % 2) == 0)
                {
                    Console.WriteLine(secondMemeber - 2);
                    secondMemeber = secondMemeber - 2;
                }
                else
                {
                    Console.WriteLine(firstMember + 2);
                    firstMember = firstMember + 2;
                }
            }
        }
    }
}
