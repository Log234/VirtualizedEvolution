using System;

namespace VirtualizedEvolution
{
    abstract class Challenge
    {
        // Metadata
        String achievementName; // Name of achievement
        String achievementDesc; // Description of achievement
        int achievementReward; // How many points awarded on success
        int needsRepetition; // If a challenge needs to be repeated multiple times to verify that it's solved correctly, use this variable. In this case the challenge will be run once.

        // Challenge variables - in case challenge and solution needs to share information

        // Challenge logic
        public abstract string getChallenge();

        // Solution logic
        public abstract bool checkSolution(string answer);
    }

    abstract class Goal
    {
        // Metadata
        String achievementName; // Name of achievement
        String achievementDesc; // Description of achievement
        int achievementReward; // How many points awarded on success

        Challenge[] challenges; // Array of challenges needed to be completed
        Goal[] goals; // Array of goals needed to be completed

        public abstract void initialize();
    }
}
