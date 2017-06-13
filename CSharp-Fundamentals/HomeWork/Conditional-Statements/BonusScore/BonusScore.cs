using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a >= 1 && a <= 9)
            {
                if (a >= 1 && a <= 3)
                {
                    a = a * 10;
                }
                else if (a >= 4 && a <= 6)
                {
                    a = a * 100;
                }
                else
                {
                    a = a * 1000;
                }

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
