using System;

namespace VirtualizedEvolution
{
    class ChallengeTemplate : Challenge // Same as filename, except without the version suffix
    {
        // Metadata
        String achievementName = "Say hello!"; // Name of achievement
        String achievementDesc = "A task where the DNA will have to reply to a greeting."; // Description of achievement
        int achievementReward = 10; // How many points awarded on success
        int needsRepetition = 1; // If a challenge needs to be repeated multiple times to verify that it's solved correctly, use this variable. In this case the challenge will be run once.

        // Challenge variables - in case challenge and solution needs to share information


        // Challenge logic
        public override string getChallenge()
        {
            return "Hello!";
        }


        // Solution logic
        public override bool checkSolution(string answer)
        {
            if (answer.Equals("Hello, world!"))
            {
                return true;

            } else
            {
                return false;
            }
        }
    }
}