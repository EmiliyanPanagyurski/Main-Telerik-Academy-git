using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double xCoord = double.Parse(Console.ReadLine());
            double yCoord = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(xCoord, 2) + Math.Pow(yCoord, 2));

            if (distance <= 2)
            {
                Console.WriteLine("yes {0:0.00}", distance);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", distance);
            }
        }
    }
}