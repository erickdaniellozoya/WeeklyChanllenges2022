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
                6 => new Challenge6(),
                7 => new Challenge7(),
                _ => new Challenge0(),
            };
        }
    }
}
