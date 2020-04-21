using System;
using System.Runtime.CompilerServices;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class IntContractTests
    {
        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Int()
        {
            int v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Int()
        {
            int v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Int()
        {
            int v1 = 50;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Decimal()
        {
            decimal v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Decimal()
        {
            decimal v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Decimal()
        {
            decimal v1 = 50;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Float()
        {
            float v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Float()
        {
            float v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Float()
        {
            float v1 = 50;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Double()
        {
            double v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Double()
        {
            double v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Double()
        {
            double v1 = 50;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Long()
        {
            long v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Long()
        {
            long v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterThan_Should_ValidAndWitouthNotifications_When_V1IsGreaterThenV2_Long()
        {
            long v1 = 50;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Int()
        {
            int v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Int()
        {
            int v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Int()
        {
            int v1 = 50;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Decimal()
        {
            decimal v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Decimal()
        {
            decimal v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Decimal()
        {
            decimal v1 = 50;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Float()
        {
            float v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Float()
        {
            float v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Float()
        {
            float v1 = 50;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Double()
        {
            double v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Double()
        {
            double v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Double()
        {
            double v1 = 50;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotGreaterThanV2_Long()
        {
            long v1 = 5;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Long()
        {
            long v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsGreaterOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsGreaterThenV2_Long()
        {
            long v1 = 50;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThanV2_Int()
        {
            int v1 = 5;
            int v2 = 10;
            var right = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Int()
        {
            int v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThenV2_Int()
        {
            int v1 = 50;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not lower than v2");

            Assert.AreEqual(false, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Int()
        {
            int v1 = 10;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Decimal()
        {
            decimal v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLoweThenV2_Int()
        {
            int v1 = 2;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Float()
        {
            float v1 = 50;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Float()
        {
            float v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Float()
        {
            float v1 = 2;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Double()
        {
            double v1 = 50;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Double()
        {
            double v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Double()
        {
            double v1 = 2;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }


        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Long()
        {
            long v1 = 50;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_InvalidAndWithNotifications_When_V1IsEqualsV2_Long()
        {
            long v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Long()
        {
            long v1 = 2;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLowerOrEqualsThanV2_Int()
        {
            int v1 = 5;
            int v2 = 10;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Int()
        {
            int v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThenV2_Int()
        {
            int v1 = 50;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not lower than v2");

            Assert.AreEqual(false, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Decimal()
        {
            decimal v1 = 10;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Decimal()
        {
            decimal v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLoweThenV2_Decimal()
        {
            decimal v1 = 2;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Float()
        {
            float v1 = 50;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Float()
        {
            float v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Float()
        {
            float v1 = 2;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Double()
        {
            double v1 = 50;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithNotifications_When_V1IsEqualsV2_Double()
        {
            double v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not greater than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Double()
        {
            double v1 = 2;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }


        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_InvalidAndWithNotifications_When_V1IsNotLowerThanV2_Long()
        {
            long v1 = 50;
            int v2 = 10;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsEqualsV2_Long()
        {
            long v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsLowerOrEqualsThan_Should_ValidAndWithoutNotifications_When_V1IsLowerThenV2_Long()
        {
            long v1 = 2;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .IsLowerOrEqualsThan(v1, v2, "Int", "V1 is not Lower than v2");

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_Int()
        {
            int v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_Decimal()
        {
            decimal v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_Float()
        {
            float v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_Double()
        {
            double v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreEquals_Long()
        {
            long v1 = 5;
            int v2 = 5;
            var right = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2NotAreEquals_Int()
        {
            int v1 = 5;
            int v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2NotAreEquals_Decimal()
        {
            int v1 = 5;
            int v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2NotAreEquals_Float()
        {
            float v1 = 5;
            int v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2NotAreEquals_Double()
        {
            double v1 = 5;
            int v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreEquals_Should_InvalidAndWithNotifications_When_V1AndV2NotAreEquals_Long()
        {
            long v1 = 5;
            int v2 = 6;
            var wrong = new Contract()
                .Requires()
                .AreEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }


        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_Int()
        {
            int v1 = 5;
            int v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_Decimal()
        {
            decimal v1 = 5;
            int v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_Float()
        {
            float v1 = 5;
            int v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_Double()
        {
            double v1 = 5;
            int v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_V1AndV2AreNotEquals_Long()
        {
            long v1 = 5;
            int v2 = 6;
            var right = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_Int()
        {
            int v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_Decimal()
        {
            decimal v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_Float()
        {
            float v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_Double()
        {
            double v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void AreNotEquals_Should_InvalidAndWithNotifications_When_V1AndV2AreEquals_Long()
        {
            long v1 = 5;
            int v2 = 5;
            var wrong = new Contract()
                .Requires()
                .AreNotEquals(v1, v2, "Int", "V1 and v2 not are equals");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }


        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_EgdeBottomOfRange()
        {
            int value = 1;
            int from = 1;
            int to = 10;

            var right = new Contract()
                .Requires()
                .IsBetween(value, from, to, "Int", "The value 1.015 is between 1 and 10");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_EgdeHigherOfRange()
        {
            int value = 10;
            int from = 1;
            int to = 10;

            var right = new Contract()
                .Requires()
                .IsBetween(value, from, to, "Int", "The value 1 is between 1 and 10");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsBetween_Should_InvalidAndWithNotifications_When_OutOfRangel()
        {
            int value = 11;
            int from = 1;
            int to = 10;

            var wrong = new Contract()
                .Requires()
                .IsBetween(value, from, to, "Int", "The value must be between 1 and 10");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsBetween_Should_ValidAndWithoutNotifications_When_WithinRange()
        {
            int value = 5;
            int from = 1;
            int to = 10;

            var right = new Contract()
                .Requires()
                .IsBetween(value, from, to, "Int", "The value 5 is between 1 and 10");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsNullOrNullable_Should_InvalidAndWithNotifications_When_Null()
        {
            var value = new Nullable<int>();

            var wrong = new Contract()
                .Requires()
                .IsNullOrNullable(value, "Int", "The Int is required");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsNullOrNullable_Should_InvalidAndWithNotifications_When_Nullable()
        {
            Nullable<int> valueNull = null;

            var wrongNull = new Contract()
                .Requires()
                .IsNullOrNullable(valueNull, "Int", "The Int is required");

            Assert.AreEqual(false, wrongNull.Valid);
            Assert.AreEqual(1, wrongNull.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("IntValidation")]
        public void IsNullOrNullable_Should_ValidAndWithoutNotifications_When_Int()
        {
            var right = new Contract()
                .Requires()
                .IsNullOrNullable(10m, "Int", "The Int is required");

            Assert.AreEqual(true, right.Valid);
        }
    }
}
