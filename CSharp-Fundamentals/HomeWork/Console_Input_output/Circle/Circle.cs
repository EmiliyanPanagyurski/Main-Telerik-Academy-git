using System;

namespace Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            if (radius > 0)
            {
                double perimeter = 2 * Math.PI * radius;
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
            }
        }
    }
}
