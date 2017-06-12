using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a >= -1000 && a <= 1000 && b >= -1000 && b <= 1000 && c >= -1000 && c <= 1000)
            {
                double d = Math.Pow(b, 2) - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine("no real roots");
                }
                else if (d == 0)
                {
                    double x = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("{0:0.00}", x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    bool greatnum = x1 > x2;

                    switch (greatnum)
                    {
                        case false:
                            Console.WriteLine("{0:0.00}", x1);
                            Console.WriteLine("{0:0.00}", x2);
                            break;
                        case true:
                            Console.WriteLine("{0:0.00}", x2);
                            Console.WriteLine("{0:0.00}", x1);
                            break;
                    }
                }
            }
        }
    }
}
