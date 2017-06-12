using System;

namespace PartyJump
{
    class PartyJump
    {
        static void Main()
        {
            string partySequence = Console.ReadLine();
            int currStep = 0;
            bool partyOn = true;

            while (partyOn)
            {
                if (partySequence[currStep] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", currStep);
                    partyOn = false;
                }
                else if(partySequence[currStep] == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", currStep);
                    partyOn = false;
                }
                else
                {
                    string stepAsString = Convert.ToString(partySequence[currStep]);
                    int stepAsNumber = int.Parse(stepAsString);

                    if (stepAsNumber % 2 == 0)
                    {
                        currStep = currStep + stepAsNumber;
                    }
                    else
                    {
                        currStep = currStep - stepAsNumber;
                    }

                    if(currStep>=partySequence.Length || currStep < 0)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", currStep);
                        partyOn = false; 
                    }
                }
            }
        }
    }
}
