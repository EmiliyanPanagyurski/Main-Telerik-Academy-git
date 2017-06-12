using System;

namespace ASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            for (int index = 33; index <= 126; index++)
                Console.Write((char)index);
        }
    }
}

