using System.Linq;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class ObjectValidationContractTests
    {
        [TestMethod]
        [TestCategory("ObjectValidation")]
        public void IsNull_Should_InvalidAndWithNotifications_When_NotNull()
        {
            object obj = 10;
            var contract = new Contract()
                .IsNull(obj, "object", "Object is not null");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
            Assert.AreEqual("Object is not null", contract.Notifications.First().Message);
        }

        [TestMethod]
        [TestCategory("ObjectValidation")]
        public void IsNotNull_Should_InvalidAndWithNotifications_When_Null()
        {
            object obj = null;
            var contract = new Contract()
                .IsNotNull(obj, "object", "Object is null");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
            Assert.AreEqual("Object is null", contract.Notifications.First().Message);
        }

        [TestMethod]
        [TestCategory("ObjectValidation")]
        public void AreEqual_Should_InvalidAndWithNotifications_When_AreNotEqual()
        {
            object obj = 10;
            object obj1 = 20;

            var contract = new Contract()
                .AreEquals(obj, obj1, "object", "Object is not equal");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
            Assert.AreEqual("Object is not equal", contract.Notifications.First().Message);
        }

        [TestMethod]
        [TestCategory("ObjectValidation")]
        public void AreNotEqual_Should_InvalidAndWithNotifications_When_AreEqual()
        {
            object obj = 10;
            object obj1 = 10;

            var contract = new Contract()
                .AreNotEquals(obj, obj1, "object", "Object is equal");

            Assert.IsTrue(contract.Invalid);
            Assert.AreEqual(1, contract.Notifications.Count);
            Assert.AreEqual("Object is equal", contract.Notifications.First().Message);
        }
    }
}