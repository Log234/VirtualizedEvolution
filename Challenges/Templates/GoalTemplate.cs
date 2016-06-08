using System;

namespace Challenges.Templates
{
    class GoalTemplate : Goal // Same as filename, except without the version suffix
    {
        // Metadata
        String achievementName = "Greet the world!";
        String achievementDesc = "A goal where the DNA will have to greet the world on 100 different languages.";
        int achievementReward = 100;

        readonly Challenge[] _challenges = new Challenge[100];
        Goal[] goals = new Goal[0];

        public override void Initialize()
        {
            // Add challenges
            _challenges[0] = new ChallengeTemplate();
            // 99 more challenges

            // Add goals
        }
    }
}