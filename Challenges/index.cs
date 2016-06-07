namespace VirtualizedEvolution
{
    // This file keeps track of all the challenges available to the DNA.
    // It is implemented in its own file so we don't have to update the client and sever every time
    // we add new challenges.

    public class ChallengeIndex
    {
        Goal[] goals = new Goal[1];
        Challenge[] challenges = new Challenge[1];

        void initialize()
        {
            // Challenges
            challenges[0] = new Addition();

            // Goals
            goals[0] = new BasicMathmathics();
        }
    }
}
