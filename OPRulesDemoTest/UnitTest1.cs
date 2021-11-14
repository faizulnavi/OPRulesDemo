using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OPRulesDemo.Entity;

namespace OPRulesDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnVideoLearningToSkiSlipOnly()
        {
            var result = Orders.CompleteOrder(new string[] { "video", "Learning To Ski" });
            Assert.AreEqual("Learning To Ski", result.Name);
            Assert.AreEqual("Generated a packing slip.", result.CheckoutProcess[0]);
            Assert.AreEqual("'First Aid' video added to the packing slip", result.CheckoutProcess[1]);
            Assert.AreEqual(2, result.CheckoutProcess.Count);
        }
    }
}
