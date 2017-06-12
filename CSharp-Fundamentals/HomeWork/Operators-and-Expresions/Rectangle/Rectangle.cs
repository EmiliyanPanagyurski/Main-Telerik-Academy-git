using System;

namespace Rectangle
{
    class Rectangle
    {
        static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double area = height * width;
            double perimeter = (2 * height) + (2 * width);

            Console.Write("{0:0.00}", area);
            Console.Write(' ');
            Console.WriteLine("{0:0.00}", perimeter);
        }
    }
}
