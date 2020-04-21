using Fluent.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Flunt.Tests
{
    [TestClass]
    public class GuidContractTests
    {
        private Dummy _dummy;

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_Distinct()
        {
            _dummy = new Dummy();
            _dummy.guidProp = Guid.NewGuid(); 

            var wrong = new Contract()
                .Requires()
                .AreEquals(_dummy.guidProp, Guid.NewGuid(), nameof(_dummy.guidProp), "Guid1 and Guid2 are distincts");
               
            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_Same()
        {
            var guid = Guid.NewGuid();
            _dummy = new Dummy();
            _dummy.guidProp = guid;

            var wrong = new Contract()
                .Requires()
                .AreNotEquals(_dummy.guidProp, guid, nameof(_dummy.guidProp), "Guid1 and Guid2 are same");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void IsEmpty_Should_ValidAndWithoutNotifications_When_Empty()
        {
            var value = Guid.Empty;

            var contract = new Contract()
                .Requires()
                .IsEmpty(value, "guid", "Guid is not empty");

            Assert.IsTrue(contract.Valid);
            Assert.AreEqual(0, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void IsEmpty_Should_InvalidAndWithNotifications_When_NotEmpty()
        {
            var value = Guid.NewGuid();

            var contract = new Contract()
                .Requires()
                .IsEmpty(value, "guid", "Guid is not empty");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void IsNotEmpty_Should_ValidAndWithoutNotifications_When_NotEmpty()
        {
            var value = Guid.NewGuid();

            var contract = new Contract()
                .Requires()
                .IsNotEmpty(value, "guid", "Guid is empty");

            Assert.IsTrue(contract.Valid);
            Assert.AreEqual(0, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("GuidValidation")]
        public void IsNotEmpty_Should_InvalidAndWithNotifications_When_Empty()
        {
            var value = Guid.Empty;

            var contract = new Contract()
                .Requires()
                .IsNotEmpty(value, "guid", "Guid is empty");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
        }

    }
}
