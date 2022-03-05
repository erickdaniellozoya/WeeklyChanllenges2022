using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace WeeklyChallenges2022Tests.ChallengesTests
{
    [TestClass]
    public class Challenge8Test
    {
        private const string Expected = "1101.011";
        [TestMethod]
        public void DoChallengeTest()
        {

            using var sw = new StringWriter();
            Console.SetOut(sw);
            new WeeklyChanllenges2022.Challenges.Challenge8().DoChallenge();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
        }
    }
}