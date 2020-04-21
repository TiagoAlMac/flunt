using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class BoolContractTests
    {
        [TestMethod]
        [TestCategory("BoolValidation")]
        public void IsTrue_Should_InValidAndWithNotifications_When_False()
        {
            var wrong = new Contract()
                .Requires()
                .IsTrue(false, "bool", "Bool is false");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("BoolValidation")]
        public void IsTrue_Should_ValidAndWithoutNotifications_When_True()
        {
            var right = new Contract()
                .Requires()
                .IsTrue(true, "bool", "Bool is false");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("BoolValidation")]
        public void IsFalse_Should_InValidAndWithNotifications_When_False()
        {
            var wrong = new Contract()
                .Requires()
                .IsFalse(true, "bool", "Bool is true");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("BoolValidation")]
        public void IsFalse_Should_ValidAndWithoutNotifications_When_False()
        {
            var right = new Contract()
                .Requires()
                .IsFalse(false, "bool", "Bool is true");
            Assert.AreEqual(true, right.Valid);
        }
    }
}