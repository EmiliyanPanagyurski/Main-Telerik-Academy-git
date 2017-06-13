using System;
using System.Numerics;

namespace CalculateThree
{
    class CalculateThree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = n - m;
            BigInteger fact1 = 1;
            BigInteger fact2 = 1;
            BigInteger fact3 = 1;
            BigInteger c = 0;

            if (n > 1 && n < 100 && m > 1 && m < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i <= m)
                    {
                        fact1 = fact1 * i;
                        fact2 = fact2 * i;
                    }
                    else
                    {
                        fact1 = fact1 * i;
                    }
                }

                for (int j = 1; j <= o; j++)
                {
                    fact3 = fact3 * j;
                }

                c = (fact1 / (fact2 * fact3));
                Console.WriteLine(c);
            }
        }
    }
}
