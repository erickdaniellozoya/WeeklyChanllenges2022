using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace WeeklyChallenges2022Tests.ChallengesTests
{
    [TestClass]
    public class Challenge0Test
    {
        private const string Expected = "1\r\n2\r\nfizz\r\n4\r\nbuzz\r\nfizz\r\n7\r\n8\r\nfizz\r\nbuzz\r\n11\r\nfizz\r\n13\r\n14\r\nfizzbuzz\r\n16\r\n17\r\nfizz\r\n19\r\nbuzz\r\nfizz\r\n22\r\n23\r\nfizz\r\nbuzz\r\n26\r\nfizz\r\n28\r\n29\r\nfizzbuzz\r\n31\r\n32\r\nfizz\r\n34\r\nbuzz\r\nfizz\r\n37\r\n38\r\nfizz\r\nbuzz\r\n41\r\nfizz\r\n43\r\n44\r\nfizzbuzz\r\n46\r\n47\r\nfizz\r\n49\r\nbuzz\r\nfizz\r\n52\r\n53\r\nfizz\r\nbuzz\r\n56\r\nfizz\r\n58\r\n59\r\nfizzbuzz\r\n61\r\n62\r\nfizz\r\n64\r\nbuzz\r\nfizz\r\n67\r\n68\r\nfizz\r\nbuzz\r\n71\r\nfizz\r\n73\r\n74\r\nfizzbuzz\r\n76\r\n77\r\nfizz\r\n79\r\nbuzz\r\nfizz\r\n82\r\n83\r\nfizz\r\nbuzz\r\n86\r\nfizz\r\n88\r\n89\r\nfizzbuzz\r\n91\r\n92\r\nfizz\r\n94\r\nbuzz\r\nfizz\r\n97\r\n98\r\nfizz\r\nbuzz";
        [TestMethod]
        public void DoChallengeTest()
        {

            using var sw = new StringWriter();
            Console.SetOut(sw);
            new WeeklyChanllenges2022.Challenges.Challenge0().DoChallenge();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
        }
    }
}