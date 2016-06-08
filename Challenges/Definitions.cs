using System;

namespace Challenges
{
    internal abstract class Challenge
    {
        // Metadata - Move to separate file?
        string achievementName; // Name of achievement
        string achievementDesc; // Description of achievement
        int achievementReward; // How many points awarded on success
        int needsRepetition; // If a challenge needs to be repeated multiple times to verify that it's solved correctly, use this variable. In this case the challenge will be run once.

        // Challenge variables - in case challenge and solution needs to share information

        // Challenge logic
        public abstract string GetChallenge();

        // Solution logic
        public abstract bool CheckSolution(string answer);
    }

    internal abstract class Goal
    {
        // Metadata
        string achievementName; // Name of achievement
        string achievementDesc; // Description of achievement
        int achievementReward; // How many points awarded on success

        readonly Challenge[] challenges; // Array of challenges needed to be completed
        readonly Goal[] goals; // Array of goals needed to be completed

        public abstract void Initialize();
    }
}
