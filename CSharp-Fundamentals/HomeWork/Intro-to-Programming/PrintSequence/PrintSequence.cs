namespace PrintSequence
{
    using System;

    class PrintSequence
    {
        static void Main()
        {
            int firstMember = 2;
            int secondMember = -3;

            Console.WriteLine(firstMember);
            Console.WriteLine(secondMember);

            for (int index = 3; index <= 10; index++)
            {
                if ((index % 2) == 0)
                {
                    Console.WriteLine(secondMember - 2);
                    secondMember = secondMember - 2;
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
