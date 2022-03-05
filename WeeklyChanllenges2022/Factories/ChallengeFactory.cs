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
                1 => new Challenge1(),
                2 => new Challenge2(),
                3 => new Challenge3(),
                4 => new Challenge4(),
                _ => new Challenge0(),
            };
        }
    }
}
