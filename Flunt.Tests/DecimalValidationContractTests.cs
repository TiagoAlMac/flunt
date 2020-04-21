using System;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class DecimalContractTests
    {
        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Decimal()
        {
            decimal v1 = 50;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Double()
        {
            double v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Double()
        {
            double v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Double()
        {
            double v1 = 50;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Float()
        {
            float v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Float()
        {
            float v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Float()
        {
            float v1 = 50;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Int()
        {
            int v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Int()
        {
            int v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Int()
        {
            int v1 = 50;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Long()
        {
            long v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Long()
        {
            long v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterThan_Should_ValidAndWitouthNotifications_When_V1IsGreaterThenV2_Long()
        {
            long v1 = 50;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Decimal()
        {
            decimal v1 = 50;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Double()
        {
            double v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Double()
        {
            double v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Double()
        {
            double v1 = 50;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Float()
        {
            float v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Float()
        {
            float v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Float()
        {
            float v1 = 50;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Int()
        {
            int v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Int()
        {
            int v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Int()
        {
            int v1 = 50;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Long()
        {
            long v1 = 5;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Long()
        {
            long v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Long()
        {
            long v1 = 50;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThanV2_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 10;
            var right = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThenV2_Decimal()
        {
            decimal v1 = 50;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not lower than v2");

            Assert.AreEqual(false, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Double()
        {
            double v1 = 10;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Double()
        {
            double v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLoweThenV2_Double()
        {
            double v1 = 2;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Float()
        {
            float v1 = 50;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Float()
        {
            float v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Float()
        {
            float v1 = 2;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Int()
        {
            int v1 = 50;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Int()
        {
            int v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Int()
        {
            int v1 = 2;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }


        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Long()
        {
            long v1 = 50;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Long()
        {
            long v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Long()
        {
            long v1 = 2;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLowerOrEqualsThanV2_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 10;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThenV2_Decimal()
        {
            decimal v1 = 50;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not lower than v2");

            Assert.AreEqual(false, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Double()
        {
            double v1 = 10;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Double()
        {
            double v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLoweThenV2_Double()
        {
            double v1 = 2;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Float()
        {
            float v1 = 50;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Float()
        {
            float v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Float()
        {
            float v1 = 2;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Int()
        {
            int v1 = 50;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithNotifications_When_V1IsEqualsV2_Int()
        {
            int v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Int()
        {
            int v1 = 2;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }


        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Long()
        {
            long v1 = 50;
            decimal v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Long()
        {
            long v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Long()
        {
            long v1 = 2;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "decimal", "V1 is not Lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_double()
        {
            double v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_float()
        {
            float v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_int()
        {
            int v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_long()
        {
            long v1 = 5;
            decimal v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreNotEquals_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreNotEquals_double()
        {
            double v1 = 5;
            decimal v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreNotEquals_float()
        {
            float v1 = 5;
            decimal v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreNotEquals_int()
        {
            int v1 = 5;
            decimal v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreNotEquals_long()
        {
            long v1 = 5;
            decimal v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_double()
        {
            double v1 = 5;
            decimal v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_float()
        {
            float v1 = 5;
            decimal v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_int()
        {
            int v1 = 5;
            decimal v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_long()
        {
            long v1 = 5;
            decimal v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_Decimal()
        {
            decimal v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_double()
        {
            double v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_float()
        {
            float v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_int()
        {
            int v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_long()
        {
            long v1 = 5;
            decimal v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "decimal", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_EgdeBottomOfRange()
        {
            var value = 1.01M;
            var from = 1.01M;
            var to = 1.02M;

            var right = new Contract()
                .Requires()
                .IsBetween(value, from, to, "decimal", "The value 1.015 is between 1.01 and 1.02");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_EgdeHigherOfRange()
        {
            var value = 1.02M;
            var from = 1.01M;
            var to = 1.02M;

            var right = new Contract()
                .Requires()
                .IsBetween(value, from, to, "decimal", "The value 1.015 is between 1.01 and 1.02");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsBetween_Should_InvalidAndWithNotifications_When_OutOfRangel()
        {
            decimal value = -1.01M;
            decimal from = 1.01M;
            decimal to = 10;

            var wrong = new Contract()
                .Requires()
                .IsBetween(value, from, to, "decimal", "The value -1.01 must be between 1.01 and 10");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_WithinRange()
        {
            var value = 1.015M;
            var from = 1.01M;
            var to = 1.02M;

            var right = new Contract()
                .Requires()
                .IsBetween(value, from, to, "decimal", "The value 1.015 is between 1.01 and 1.02");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsNullOrNullable_Should_InvalidAndWithNotifications_When_Null()
        {            
            var value = new Nullable<decimal>();
            
            var wrong = new Contract()
                .Requires()
                .IsNullOrNullable(value, "decimal", "The decimal is required");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsNullOrNullable_Should_InvalidAndWithNotifications_When_Nullable()
        {
            Nullable<decimal> valueNull = null;

            var wrongNull = new Contract()
                .Requires()
                .IsNullOrNullable(valueNull, "decimal", "The decimal is required");

            Assert.AreEqual(false, wrongNull.Valid);
            Assert.AreEqual(1, wrongNull.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("DecimalValidation")]
        public void IsNullOrNullable_Should_ValidAndWithoutNotifications_When_Decimal()
        {
            var right = new Contract()
                .Requires()
                .IsNullOrNullable(10m, "decimal", "The decimal is required");

            Assert.AreEqual(true, right.Valid);
        }
    }
}
