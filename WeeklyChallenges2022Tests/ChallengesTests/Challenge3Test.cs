using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace WeeklyChallenges2022Tests.ChallengesTests
{
    [TestClass]
    public class Challenge3Test
    {
        private const string Expected = "2\r\n3\r\n5\r\n7\r\n11\r\n13\r\n17\r\n19\r\n23\r\n29\r\n31\r\n37\r\n41\r\n43\r\n47\r\n53\r\n59\r\n61\r\n67\r\n71\r\n73\r\n79\r\n83\r\n89\r\n97";
        [TestMethod]
        public void DoChallengeTest()
        {

            using var sw = new StringWriter();
            Console.SetOut(sw);
            new WeeklyChanllenges2022.Challenges.Challenge3().DoChallenge();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
        }
    }
}