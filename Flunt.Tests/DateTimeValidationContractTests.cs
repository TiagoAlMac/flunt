using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fluent.Tests.Entities;

namespace Flunt.Tests
{
    [TestClass]
    public class DateTimeContractTests
    {
        private Dummy _dummy;

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_Date2IsAfter()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2005, 5, 15, 16, 0, 0);

            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2")
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2")
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_Date2IsBefore()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2005, 5, 15, 16, 0, 0);

            var right = new Contract()
                .Requires()
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(-2), nameof(_dummy.dateTimeProp), "Date 1 is not greater than Date 2")
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(-2), nameof(_dummy.dateTimeProp), "Date 1 is not greater than Date 2")
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(-2), nameof(_dummy.dateTimeProp), "Date 1 is not greater than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_Date2IsEquals()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2005, 5, 15, 16, 0, 0);

            var equal = new Contract()
                .Requires()
                .IsGreaterThan(_dummy.dateTimeProp, _dummy.dateTimeProp, nameof(_dummy.dateTimeProp), "Date 1 and Date 2 are equals");

            Assert.AreEqual(false, equal.Valid);
            Assert.AreEqual(1, equal.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_Date2IsAfter()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 1, 1, 12, 0, 0);

            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(1), nameof(_dummy.dateTimeProp), "Date 1 should be greater than Date 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_Date2IsBefore()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 1, 1, 12, 0, 0);

            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp, nameof(_dummy.dateTimeProp), "Date 1 is not greater or equals than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(-1), nameof(_dummy.dateTimeProp), "Date 1 is not greater or equals than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(-1), nameof(_dummy.dateTimeProp), "Date 1 is not greater or equals than Date 2")
                .IsGreaterOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(-1), nameof(_dummy.dateTimeProp), "Date 1 is not greater or equals than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_Date2IsBefore()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 9, 26, 15, 0, 0);

            var wrong = new Contract()
                .Requires()
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2")
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2")
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_Date2IsAfter()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 9, 26, 15, 0, 0);

            var right = new Contract()
                .Requires()
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2")
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2")
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_Date2IsEquals()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2005, 5, 15, 16, 0, 0);

            var equal = new Contract()
                .Requires()
                .IsLowerThan(_dummy.dateTimeProp, _dummy.dateTimeProp, nameof(_dummy.dateTimeProp), "Date 1 and Date 2 are equals");

            Assert.AreEqual(false, equal.Valid);
            Assert.AreEqual(1, equal.Notifications.Count);
        }


        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_Date2IsBefore()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 9, 26, 15, 0, 0);

            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(-1), nameof(_dummy.dateTimeProp), "Date 1 should be lower than Date 2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(3, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_Date2IsAfter()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 9, 26, 15, 0, 0);

            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMilliseconds(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddSeconds(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2")
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp.AddMinutes(1), nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_Date2IsEqual()
        {
            _dummy = new Dummy();
            _dummy.dateTimeProp = new DateTime(2017, 9, 26, 15, 0, 0);

            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(_dummy.dateTimeProp, _dummy.dateTimeProp, nameof(_dummy.dateTimeProp), "Date 1 is not lower than Date 2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsBetween_Should_InvalidAndWithNotifications_When_OutOfRange()
        {
            var startDate = new DateTime(2018, 01, 01);
            var endDate = new DateTime(2018, 01, 10);
            var date = new DateTime(2019, 01, 5);

            var invalid = new Contract().Requires()
                .IsBetween(date, startDate, endDate, "prop", "message");

            Assert.AreEqual(false, invalid.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_EgdeBottomOfRange()
        {
            var startDate = new DateTime(2018, 01, 01);
            var endDate = new DateTime(2018, 01, 10);
            var date = new DateTime(2018, 01, 01);

            var valid = new Contract().Requires()
                .IsBetween(date, startDate, endDate, "prop", "message");

            Assert.AreEqual(true, valid.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_EgdeHigherOfRange()
        {
            var startDate = new DateTime(2018, 01, 01);
            var endDate = new DateTime(2018, 01, 10);
            var date = new DateTime(2018, 01, 10);

            var valid = new Contract().Requires()
                .IsBetween(date, startDate, endDate, "prop", "message");

            Assert.AreEqual(true, valid.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_WithinRange()
        {
            var startDate = new DateTime(2018, 01, 01);
            var endDate = new DateTime(2018, 01, 10);
            var date = new DateTime(2018, 01, 5);

            var valid = new Contract().Requires()
                .IsBetween(date, startDate, endDate, "prop", "message");

            Assert.AreEqual(true, valid.Valid);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsNullOrNullable_Should_InvalidAndWithNotifications_When_Null()
        {
            var date = new Nullable<DateTime>();

            var wrong = new Contract()
                .Requires()
                .IsNullOrNullable(date, "datetime", "The date is required");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsNullOrNullable_Should_InvalidAndWithNotifications_When_Nullable()
        {
            Nullable<DateTime> dateNull = null;

            var wrongNull = new Contract()
                .Requires()
                .IsNullOrNullable(dateNull, "datetime", "The date is required");
        }

        [TestMethod]
        [TestCategory("DateTimeValidation")]
        public void IsNullOrNullable_Should_ValidAndWithoutNotifications_When_Object()
        {
            var right = new Contract()
                .Requires()
                .IsNullOrNullable(new DateTime(2017, 10, 30), "datetime", "The date is required");

            Assert.AreEqual(true, right.Valid);
        }
    }
}
