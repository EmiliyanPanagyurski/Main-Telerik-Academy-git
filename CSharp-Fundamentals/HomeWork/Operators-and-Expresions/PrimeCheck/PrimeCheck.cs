﻿using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int digit = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (digit <= 100)
            {
                for (int i = 2; i <= Math.Sqrt(digit); i++)
                {
                    if (digit % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (digit == 1 || digit < 1)
                {
                    isPrime = false;
                }

                Console.WriteLine(isPrime.ToString().ToLower());
            }
        }
    }
}
