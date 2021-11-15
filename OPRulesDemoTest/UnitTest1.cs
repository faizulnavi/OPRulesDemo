using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OPRulesDemo.Entity;

namespace OPRulesDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnVideoforLearningToSkiSlipOnly()
        {
            var result = Orders.CompleteOrder(new string[] { "video", "Learning To Ski" });
            Assert.AreEqual("Learning To Ski", result.Name);
            Assert.AreEqual("Generate a packing slip for shipping.", result.CheckoutProcess[0]);
            Assert.AreEqual("'First Aid' added to the packing slip", result.CheckoutProcess[1]);
            Assert.AreEqual(2, result.CheckoutProcess.Count);
        }

        [TestMethod]
        public void ShouldReturnSlipforVideoOnly()
        {
            var result = Orders.CompleteOrder(new string[] { "video", "Anyvideo" });
            Assert.AreEqual("Anyvideo", result.Name);
            Assert.AreEqual("Generate a packing slip for shipping.", result.CheckoutProcess[0]);
            Assert.AreEqual(1, result.CheckoutProcess.Count);
        }
        [TestMethod]
        public void ShouldReturnforUpgradeSlipOnly()
        {
            var result = Orders.CompleteOrder(new string[] { "Upgrade", "Random" });
            Assert.IsNull(result.Name);
            Assert.AreEqual("Generate a packing slip for shipping.", result.Name[0]);
            Assert.AreEqual("Apply the upgrade", result.CheckoutProcess[1]);
            Assert.AreEqual("Mail Sent", result.CheckoutProcess[2]);
            Assert.AreEqual(3, result.CheckoutProcess.Count);

        }

        [TestMethod]
        public void ShouldReturnforMembershipSlip()
        {
            var result = Orders.CompleteOrder(new string[] { "Membership", "Test" });
            Assert.IsNull(result.Name);
            Assert.AreEqual("Generate a packing slip for shipping.", result.CheckoutProcess[0]);
            Assert.AreEqual("Membership Activated", result.CheckoutProcess[1]);
            Assert.AreEqual("Mail Sent to Customer", result.CheckoutProcess[2]);
            Assert.AreEqual(3, result.CheckoutProcess.Count);

        }

    }
}
