using WeeklyChanllenges2022.Interfaces;
using WeeklyChanllenges2022.Challenges;

namespace WeeklyChanllenges2022.Factories
{
    public static class ChallengeFactory
    {
        public static IChallenge FactoryChallenge(int challenge)
        {
            return challenge switch
            {
                0 => new Challenge0(),
                _ => null,
            };
        }
    }
}
