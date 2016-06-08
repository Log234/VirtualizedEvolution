using Challenges.Challenges;

namespace Challenges.Goals
{
    internal class BasicMathmathics : Goal // Same as filename, except without the version suffix
    {
        private readonly Challenge[] _challenges = new Challenge[100];

        // Metadata
        private string achievementName = "Greet the world!";
        private string achievementDesc = "A goal where the DNA will have to greet the world on 100 different languages.";
        private int achievementReward = 100;

        public override void Initialize()
        {
            // Add challenges
            _challenges[0] = new Addition();
            // 99 more challenges

            // Add goals
        }
    }
}