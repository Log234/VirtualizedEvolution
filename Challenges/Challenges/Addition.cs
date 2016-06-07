using System;

namespace VirtualizedEvolution
{
    class Addition : Challenge // Same as filename, except without the version suffix
    {
        // Metadata
        String achievementName = "Addition";
        String achievementDesc = "A task where the DNA will have to calculate the sum of two integers.";
        int achievementReward = 10;
        int needsRepetition = 2; // If a challenge needs to be repeated multiple times to verify that it's solved correctly, use this variable. In this case the challenge will be run twice.

        // Challenge variables - in case challenge and solution needs to share information
        int numberA;
        int numberB;

        // Challenge logic
        public override string getChallenge()
        {
            Random rnd = new Random();
            numberA = rnd.Next(0, 99999);
            numberB = rnd.Next(0, 99999);

            return "" + numberA + " + " + numberB;
        }


        // Solution logic
        public override bool checkSolution(string answer)
        {
            int sum = numberA + numberB;

            if (answer.Equals(sum.ToString()))
            {
                return true;

            } else
            {
                return false;
            }
        }
    }
}