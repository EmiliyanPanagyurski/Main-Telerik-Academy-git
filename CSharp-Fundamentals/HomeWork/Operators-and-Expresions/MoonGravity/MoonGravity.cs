using System;

namespace MoonGravity
{
    class MoonGravity
    {   
        /// <summary>
        /// input your weight and outputs your weight in the moon
        /// </summary>
        static void Main()
        {
            string input = Console.ReadLine();

            float inputAsNumber = float.Parse(input);
            float moonGravity = (float)0.17;

            Console.WriteLine("{0:0.000}", moonGravity * inputAsNumber);
        }
    }
}
