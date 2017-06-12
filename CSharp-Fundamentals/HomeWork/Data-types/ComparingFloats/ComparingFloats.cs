using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            double parsedInputOne = double.Parse(inputOne);
            double parsedInputTwo = double.Parse(inputTwo);
            double eps = 0.000001;

            if (Math.Abs(parsedInputOne - parsedInputTwo) <= eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}