using System;

namespace Challenges.Challenges
{
    internal class Addition : Challenge // Same as filename, except without the version suffix
    {
        // Metadata
        string achievementName = "Addition";
        string achievementDesc = "A task where the DNA will have to calculate the sum of two integers.";
        int achievementReward = 10;
        int needsRepetition = 2; // If a challenge needs to be repeated multiple times to verify that it's solved correctly, use this variable. In this case the challenge will be run twice.

        // Challenge variables - in case challenge and solution needs to share information
        private int _numberA;
        private int _numberB;

        // Challenge logic
        public override string GetChallenge()
        {
            Random rnd = new Random();
            _numberA = rnd.Next(0, 99999);
            _numberB = rnd.Next(0, 99999);

            return "" + _numberA + " + " + _numberB;
        }


        // Solution logic
        public override bool CheckSolution(string answer)
        {
            var sum = _numberA + _numberB;

            return answer.Equals(sum.ToString());
        }
    }
}