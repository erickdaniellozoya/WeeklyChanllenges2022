using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeeklyChanllenges2022.Interfaces;

namespace WeeklyChallenges2022Tests.FactoriesTests
{
    [TestClass]
    public class ChallengeFactoryTest
    {
        [TestMethod]
        public void FactoryChallengeTest_Option0()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(0);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge0().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }

        [TestMethod]
        public void FactoryChallengeTest_Option1()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(1);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge1().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }

        [TestMethod]
        public void FactoryChallengeTest_Option2()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(2);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge2().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }

        [TestMethod]
        public void FactoryChallengeTest_Option3()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(3);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge3().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }

        [TestMethod]
        public void FactoryChallengeTest_Option4()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(4);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge4().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }

        [TestMethod]
        public void FactoryChallengeTest_Option6()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(6);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge6().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }

        [TestMethod]
        public void FactoryChallengeTest_Option7()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(7);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge7().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }

        [TestMethod]
        public void FactoryChallengeTest_Option8()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(8);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge8().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }

        [TestMethod]
        public void FactoryChallengeTest_DefaultOption()
        {
            IChallenge challenge = WeeklyChanllenges2022.Factories.ChallengeFactory.FactoryChallenge(-1);
            var expected = new WeeklyChanllenges2022.Challenges.Challenge0().GetType();
            Assert.IsNotNull(challenge);
            Assert.AreEqual(expected, challenge.GetType());
        }
    }
}