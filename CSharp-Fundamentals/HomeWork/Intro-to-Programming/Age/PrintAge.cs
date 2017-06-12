namespace Age
{
    using System;

    class PrintAge
    {
        static void Main()
        {
            var userInput = Console.ReadLine();

            DateTime now = DateTime.Now;
            DateTime result = DateTime.Parse(userInput);

            int age = now.Year - result.Year;
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
