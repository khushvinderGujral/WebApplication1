using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.BusinessLogicLayer;
using WebApplication1.BusinessObjects;
using WebApplication1.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BusinessRuleTestForNonPayment()
        {
            Assert.AreEqual(true, BusinessRuleSystem.PaymentProcessingSystem(0));
        }
        [TestMethod]
        public void BusinessRuleTestProductBook()
        {
            Assert.AreEqual(true, BusinessRuleSystem.PaymentProcessingSystem(SubPaymentWay.PhyscialorBook));
        }
        [TestMethod]
        public void BusinessRuleTestForPhyscialProduct()
        {
            Assert.AreEqual(true, BusinessRuleSystem.PaymentProcessingSystem(SubPaymentWay.PhyscialProdcut));
        }
        [TestMethod]
        public void BusinessRuleTestForUpgrade()
        {
            Assert.AreEqual(true, BusinessRuleSystem.PaymentProcessingSystem(SubPaymentWay.UpgradeToMembers));
        }
        [TestMethod]
        public void BusinessRuleTestForBook()
        {
            Assert.AreEqual(true, BusinessRuleSystem.PaymentProcessingSystem(SubPaymentWay.book));
        }
        [TestMethod]
        public void BusinessRuleTestForUpgradeToMemberShip()
        {
            Assert.AreEqual(true, BusinessRuleSystem.PaymentProcessingSystem(SubPaymentWay.MemeberShip));
        }
        [TestMethod]
        public void BusinessRuleTestForUpgradeToLearningForSki()
        {
            Assert.AreEqual(true, BusinessRuleSystem.PaymentProcessingSystem(SubPaymentWay.LearningForSki));
        }

    }
}
