using System;

namespace VirtualizedEvolution
{
    class BasicMathmathics : Goal // Same as filename, except without the version suffix
    {
        // Metadata
        String achievementName = "Greet the world!";
        String achievementDesc = "A goal where the DNA will have to greet the world on 100 different languages.";
        int achievementReward = 100;

        Challenge[] challenges = new Challenge[100];
        Goal[] goals = new Goal[0];

        public override void initialize()
        {
            // Add challenges
            challenges[0] = new Addition();
            // 99 more challenges

            // Add goals
        }
    }
}