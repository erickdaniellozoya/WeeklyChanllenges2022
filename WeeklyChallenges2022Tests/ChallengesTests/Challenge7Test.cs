using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace WeeklyChallenges2022Tests.ChallengesTests
{
    [TestClass]
    public class Challenge7Test
    {
        private const string Expected = "To begin to toboggan first buy a toboggan, but don't buy too big a toboggan. Too big a toboggan is too big a toboggan to buy to begin to toboggan.\r\nto - 5 times\r\nbegin - 2 times\r\ntoboggan - 5 times\r\nfirst - 1 times\r\nbuy - 3 times\r\na - 4 times\r\ntoboggan, - 1 times\r\nbut - 1 times\r\ndont - 1 times\r\ntoo - 3 times\r\nbig - 3 times\r\nis - 1 times";
        [TestMethod]
        public void DoChallengeTest()
        {

            using var sw = new StringWriter();
            Console.SetOut(sw);
            new WeeklyChanllenges2022.Challenges.Challenge7().DoChallenge();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
        }
    }
}