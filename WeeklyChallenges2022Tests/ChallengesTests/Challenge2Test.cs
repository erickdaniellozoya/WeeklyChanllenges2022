using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace WeeklyChallenges2022Tests.ChallengesTests
{
    [TestClass]
    public class Challenge2Test
    {
        private const string Expected = "0\r\n1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34\r\n55\r\n89\r\n144\r\n233\r\n377\r\n610\r\n987\r\n1597\r\n2584\r\n4181\r\n6765\r\n10946\r\n17711\r\n28657\r\n46368\r\n75025\r\n121393\r\n196418\r\n317811\r\n514229\r\n832040\r\n1346269\r\n2178309\r\n3524578\r\n5702887\r\n9227465\r\n14930352\r\n24157817\r\n39088169\r\n63245986\r\n102334155\r\n165580141\r\n267914296\r\n433494437\r\n701408733\r\n1134903170\r\n1836311903\r\n2971215073\r\n4807526976\r\n7778742049";
        [TestMethod]
        public void DoChallengeTest()
        {

            using var sw = new StringWriter();
            Console.SetOut(sw);
            new WeeklyChanllenges2022.Challenges.Challenge2().DoChallenge();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
        }
    }
}