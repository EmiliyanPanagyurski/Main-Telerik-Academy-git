using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger c;
            BigInteger fact1 = 1;
            BigInteger fact2 = 1;
            BigInteger fact3 = 1;

            for (int i = 2; i <= 2 * n; i++)
            {
                if (i <= n)
                {
                    fact1 = fact1 * i;
                    fact2 = fact2 * i;
                    fact3 = fact3 * i;
                }
                else if (i == n + 1)
                {
                    fact1 = fact1 * i;
                    fact2 = fact2 * i;
                }
                else
                {
                    fact1 = fact1 * i;
                }
            }

            c = fact1 / (fact2 * fact3);
            Console.WriteLine(c);
        }
    }
}
