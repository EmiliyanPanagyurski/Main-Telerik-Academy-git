using System;
using System.Numerics;

namespace CalculateAggain
{
    class CalculateAggain
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint m = uint.Parse(Console.ReadLine());
            BigInteger nFactoriel = 1;
            BigInteger mFactoriel = 1;

            if (n > 1 && n < 100 && m > 1 && m < 100)
            {
                for (uint i = 1, j = 1; i <= n || j <= m; i++, j++)
                {
                    if (j <= m)
                    {
                        nFactoriel = nFactoriel * i;
                        mFactoriel = mFactoriel * j;
                    }
                    else
                    {
                        nFactoriel = nFactoriel * i;
                    }
                }

                Console.WriteLine(nFactoriel / mFactoriel);
            }
        }
    }
}
