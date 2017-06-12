using System;

namespace Point_Circle_Rectangle
{
    class Check
    {
        static void Main()
        {
            float xCoord = float.Parse(Console.ReadLine());
            float yCoord = float.Parse(Console.ReadLine());

            if (xCoord <= 1000 && xCoord >= -1000 && yCoord <= 1000 && yCoord >= -1000)
            {
                float distance = (float)Math.Sqrt(Math.Pow((xCoord - 1), 2) + Math.Pow((yCoord - 1), 2));

                if (distance <= 1.5)
                {
                    Console.Write("inside circle ");
                }
                else
                {
                    Console.Write("outside circle ");
                }

                if (xCoord >= -1 && xCoord <= 5)
                {
                    if (yCoord <= 1 && yCoord >= -1)
                    {
                        Console.WriteLine("inside rectangle");
                    }
                    else
                    {
                        Console.WriteLine("outside rectangle");
                    }
                }
                else
                {
                    Console.WriteLine("outside rectangle");
                }
            }
        }
    }
}
