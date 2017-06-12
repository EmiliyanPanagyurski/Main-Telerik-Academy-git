using System;

namespace SecretMessage
{
    class SecretMessage
    {
        static void Main()
        {
            string resultMessage = "";

            while (true)
            {
                string i = Console.ReadLine();

                if (i == "end")
                {
                    Console.WriteLine(resultMessage);
                    break;
                }
                else
                {
                    int s = int.Parse(Console.ReadLine());
                    string text = Console.ReadLine();
                    int position = int.Parse(i);

                    if (position < 0)
                    {
                        position = text.Length + position;
                        if (s < 0)
                        {
                            for (int j = position; j >= 0; j = j + s)
                            {
                                resultMessage = resultMessage + text[j];
                            }
                        }
                        else
                        {
                            for (int j = position; j < text.Length; j = j + s)
                            {
                                resultMessage = resultMessage + text[j];
                            }
                        }
                    }
                    else if (position > 0)
                    {
                        if (s < 0)
                        {
                            for (int j = position; j >= 0; j = j + s)
                            {
                                resultMessage = resultMessage + text[j];
                            }
                        }
                        else
                        {
                            for (int j = position; j < text.Length; j = j + s)
                            {
                                resultMessage = resultMessage + text[j];
                            }
                        }
                    }
                    else
                    {
                        if (s < 0)
                        {
                            for (int j = position; j >= 0; j = j + s)
                            {
                                resultMessage = resultMessage + text[j];
                            }
                        }
                        else
                        {
                            for (int j = position; j < text.Length; j = j + s)
                            {
                                resultMessage = resultMessage + text[j];
                            }
                        }
                    }
                }
            }
        }
    }
}
