using Fluent.Tests.Entities;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class ContractTests
    {
        private Dummy _dummy;

        [TestMethod]
        [TestCategory("ContractValidation")]
        public void Join_Should_DontUniteNotifications_When_NullItems()
        {
            _dummy = new Dummy();

            var contract = new Contract()
                .Requires()
                .IsDigit(_dummy.stringProp, nameof(_dummy.stringProp), "Value is not a digit")
                .Join(null);

            Assert.AreEqual(1, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("ContractValidation")]
        public void Join_Should_JoinNotifications_When_NotNullItems()
        {
            _dummy = new Dummy();
            _dummy.stringProp = "A";

            var firstContract = new Contract()
                .Contains(_dummy.stringProp, "1", nameof(_dummy.stringProp), "The value contains the digit 1");

            var contract = new Contract()
                .Requires()
                .IsDigit(_dummy.stringProp, nameof(_dummy.stringProp), "Value is not a digit")
                .Join(firstContract);

            Assert.AreEqual(2, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("ContractValidation")]
        public void Join_Should_DontUniteNotifications_When_ContractValid()
        {
            _dummy = new Dummy();
            _dummy.stringProp = "A";

            var firstContract = new Contract()
                .Contains(_dummy.stringProp, "A", nameof(_dummy.stringProp), "The value contains the digit 1");

            var contract = new Contract()
                .Requires()
                .IsDigit(_dummy.stringProp, nameof(_dummy.stringProp), "Value is not a digit")
                .Join(firstContract);

            Assert.AreEqual(1, contract.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("ContractValidation")]
        public void Join_Should_JoinNotifications_When_ContractInvalid()
        {
            _dummy = new Dummy();
            _dummy.stringProp = "A";

            var firstContract = new Contract()
                .Contains(_dummy.stringProp, "B", nameof(_dummy.stringProp), "The value contains the digit 1");

            var contract = new Contract()
                .Requires()
                .IsDigit(_dummy.stringProp, nameof(_dummy.stringProp), "Value is not a digit")
                .Join(firstContract);

            Assert.AreEqual(2, contract.Notifications.Count);
        }
    }
}
