using System;

namespace Mix
{
    class Mix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = new string[n];
            int[] mix = new int[n - 1];
            int[] sub = new int[n - 1];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            
            for (int i = 0; i < n - 1; i++)
            {
                string a = Convert.ToString(numbers[i][1]);
                string b = Convert.ToString(numbers[i + 1][0]);
                int a1 = int.Parse(a);
                int b1 = int.Parse(b);
                mix[i] = a1 * b1;
                a = Convert.ToString(numbers[i]);
                b = Convert.ToString(numbers[i + 1]);
                a1 = int.Parse(a);
                b1 = int.Parse(b);
                sub[i] = Math.Abs(a1 - b1);
            }
            
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(mix[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(sub[i] + " ");
            }

            Console.WriteLine();
           
        }
    }
}
