using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class StringContractTests
    {
        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotNullOrEmpty_Should_InvalidAndWithNotifications_When_Null()
        {
            var wrong = new Contract()
                .Requires()
                .IsNotNullOrEmpty(null, "string", "String is Null");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotNullOrEmpty_Should_InvalidAndWithNotifications_When_Empty()
        {
            var wrong = new Contract()
                .Requires()
                .IsNotNullOrEmpty("", "string", "String is Empty");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_String()
        {
            var right = new Contract()
                .Requires()
                .IsNotNullOrEmpty("Some valid string", "string", "String is Null");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotNullOrWhiteSpace_Should_InvalidAndWithNotifications_When_Null()
        {
            var wrong = new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace(null, "string", "String is Null");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotNullOrWhiteSpace_Should_InvalidAndWithNotifications_When_WhiteSpace()
        {
            var wrong = new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace("     ", "string", "String is Empty");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }


        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNotNullOrWhiteSpace_Should_ValidAndWithoutNotifications_When_String()
        {
            var right = new Contract()
                .Requires()
                .IsNotNullOrWhiteSpace("Some valid string", "string", "String is Null");
            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNullOrEmpty_Should_ValidAndWithoutNotifications_When_Null()
        {
            var right = new Contract()
                .Requires()
                .IsNullOrEmpty(null, "string", "String is Null");

            Assert.AreEqual(true, right.Valid);
            Assert.AreEqual(0, right.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNullOrEmpty_Should_ValidAndWithoutNotifications_When_Empty()
        {
            var right = new Contract()
                .Requires()
                .IsNullOrEmpty("", "string", "String is Empty");

            Assert.AreEqual(true, right.Valid);
            Assert.AreEqual(0, right.Notifications.Count);
        }


        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsNullOrEmpty_Should_InvalidAndWithNotifications_When_String()
        {
            var wrong = new Contract()
                .Requires()
                .IsNullOrEmpty("Some valid string", "string", "String is Null");
            Assert.AreEqual(false, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void MinLen_Should_InvalidAndWithNotifications_When_Smaller()
        {
            var wrong = new Contract()
                .Requires()
                .HasMinLen("null", 5, "string", "String len is less than permited");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void MinLen_Should_ValidAndWithoutNotifications_When_Bigger()
        {
            var right = new Contract()
                .Requires()
                .HasMinLen("Some Valid String", 5, "string", "String len is less than permited");

            Assert.AreEqual(true, right.Valid);
        }


        [TestMethod]
        [TestCategory("StringValidation")]
        public void MinLen_Should_ValidAndWithoutNotifications_When_Equal()
        {
            var right = new Contract()
                .Requires()
                .HasMinLen("Equal", 5, "string", "String len is less than permited");

            Assert.IsTrue(right.Valid);
            Assert.AreEqual(0, right.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void MaxLen_Should_InvalidAndWithNotifications_When_Bigger()
        {
            var wrong = new Contract()
                .Requires()
                .HasMaxLen("null", 3, "string", "String len is more than permited");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void MaxLen_Should_ValidAndWithoutNotifications_When_Smaller()
        {
            var right = new Contract()
                .Requires()
                .HasMaxLen("Some", 5, "string", "String len is more than permited");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void MaxLen_Should_ValidAndWithoutNotifications_When_Equal()
        {
            var right = new Contract()
                .Requires()
                .HasMaxLen("Equal", 5, "string", "String len is more than permited");

            Assert.IsTrue(right.Valid);
            Assert.AreEqual(0, right.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Len_Should_InvalidAndWithNotifications_When_Smaller()
        {
            var wrong = new Contract()
                .Requires()
                .HasLen("null", 3, "string", "String len is less than permited");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Len_Should_InvalidAndWithNotifications_When_Bigger()
        {
            var wrong = new Contract()
                .Requires()
                .HasLen("Bigger", 3, "string", "String len is more than permited");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Len_Should_ValidAndWithoutNotifications_When_Egual()
        {
            var right = new Contract()
                .Requires()
                .HasLen("Some1", 5, "string", "String len is less than permited");

            Assert.AreEqual(true, right.Valid);
            Assert.AreEqual(0, right.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Contains_Should_InvalidAndWithNotifications_When_DoNotContains()
        {
            var wrong = new Contract()
                .Requires()
                .Contains("some text here", "banana", "string", "String does not contains banana");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Contains_Should_ValidAndWithoutNotifications_When_Contains()
        {
            var right = new Contract()
                .Requires()
                .Contains("some banana here", "banana", "string", "String does not contains banana");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsEmail_Should_InvalidAndWithNotifications_When_ItNotAnEmail()
        {
            var wrong = new Contract()
                .Requires()
                .IsEmail("wrongemail", "string", "Invalid E-mail");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsEmail_Should_ValidAndWithoutNotifications_When_ItAnEmail()
        {
            var right = new Contract()
                .Requires()
                .IsEmail("andrebaltieri@gmail.com", "string", "Invalid E-mail");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsEmailOrEmpty_Should_ValidAndWithoutNotifications_When_Empty()
        {
            var right = new Contract()
                .Requires()
                .IsEmailOrEmpty("", "string", "Invalid E-mail");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsUrl_Should_InvalidAndWithNotifications_When_ItNotAnUrl()
        {
            var wrong = new Contract()
                .Requires()
                .IsUrl("wrongurl", "string", "Invalid URL");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsUrl_Should_ValidAndWithoutNotifications_When_ItAnUrl()
        {
            var right = new Contract()
                .Requires()
                .IsUrl("https://gmail.com", "string", "Invalid URL")
                .IsUrl("http://gmail.com", "string", "Invalid URL")
                .IsUrl("http://balta.io/", "string", "Invalid URL");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsUrlOrEmpty_Should_ValidAndWithoutNotifications_When_Empty()
        {
            var right = new Contract()
                .Requires()
                .IsUrlOrEmpty("", "string", "Invalid URL");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Match_Should_InvalidAndWithNotifications_When_DontMatch()
        {
            var wrong = new Contract()
                .Requires()
                .Matchs("wrongurl", @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", "string", "Invalid URL");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }


        [TestMethod]
        [TestCategory("StringValidation")]
        public void Match_Should_InvalidAndWithNotifications_When_StringEmpty()
        {
            var wrong = new Contract()
                .Requires()
                .Matchs(null, @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", "string", "Invalid URL");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void Match_Should_ValidAndWithoutNotifications_When_Match()
        {
            var right = new Contract()
                .Requires()
                .Matchs("http://gmail.com", @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", "string", "Invalid URL");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsDigit_Should_InvalidAndWithNotifications_When_ItNotAnDigit()
        {
            var wrong = new Contract()
                .Requires()
                .IsDigit("asdfa989798", "string", "String must have digits only");

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void IsDigit_Should_ValidAndWithoutNotifications_When_ItAnDigit()
        {
            var right = new Contract()
                .Requires()
                .IsDigit("1234567890", "string", "String must have digits only");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMinLengthIfNotNullOrEmpty_Should_InvalidAndWithNotifications_When_Smaller()
        {
            var errorMessage = "String not null or empty and length is less than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMinLengthIfNotNullOrEmpty("123456789", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMinLengthIfNotNullOrEmpty_Should_InvalidAndWithNotifications_When_SmallerAndWhiteSpace()
        {
            var errorMessage = "String not null or empty and length is less than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMinLengthIfNotNullOrEmpty("         ", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMinLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_Null()
        {
            var errorMessage = "String not null or empty and length is less than permitted";
            var right = new Contract()
                .Requires()
                .HasMinLengthIfNotNullOrEmpty(null, 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMinLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_Empty()
        {
            var errorMessage = "String not null or empty and length is less than permitted";
            var right = new Contract()
                .Requires()
                .HasMinLengthIfNotNullOrEmpty("", 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMinLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_Bigger()
        {
            var errorMessage = "String not null or empty and length is less than permitted";
            var right = new Contract()
                .Requires()
                .HasMinLengthIfNotNullOrEmpty("1234567890", 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMaxLengthIfNotNullOrEmpty_Should_InvalidAndWithNotifications_When_MorePermitted()
        {
            var errorMessage = "String not null or empty and length is more than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMaxLengthIfNotNullOrEmpty("12345678901", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMaxLengthIfNotNullOrEmpty_Should_InvalidAndWithNotifications_When_BiggerAndWhiteSpace()
        {
            var errorMessage = "String not null or empty and length is more than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMaxLengthIfNotNullOrEmpty("           ", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMaxLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_Null()
        {
            var errorMessage = "String not null or empty and length is more than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMaxLengthIfNotNullOrEmpty(null, 10, "string", errorMessage);

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMaxLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_Empty()
        {
            var errorMessage = "String not null or empty and length is more than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMaxLengthIfNotNullOrEmpty("", 10, "string", errorMessage);

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMaxLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_SmallerPermitted()
        {
            var errorMessage = "String not null or empty and length is more than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMaxLengthIfNotNullOrEmpty("123456789", 10, "string", errorMessage);

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasMaxLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_LimitPermitted()
        {
            var errorMessage = "String not null or empty and length is more than permitted";
            var wrong = new Contract()
                .Requires()
                .HasMaxLengthIfNotNullOrEmpty("1234567890", 10, "string", errorMessage);

            Assert.AreEqual(true, wrong.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasExactLengthIfNotNullOrEmpty_Should_InvalidAndWithNotifications_When_Smaller()
        {
            var errorMessage = "String not null or empty and length is different than permitted";
            var wrong = new Contract()
                .Requires()
                .HasExactLengthIfNotNullOrEmpty("123456789", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasExactLengthIfNotNullOrEmpty_Should_InvalidAndWithNotifications_When_Bigger()
        {
            var errorMessage = "String not null or empty and length is different than permitted";
            var wrong = new Contract()
                .Requires()
                .HasExactLengthIfNotNullOrEmpty("12345678901", 10, "string", errorMessage);

            Assert.AreEqual(false, wrong.Valid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasExactLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_Null()
        {
            var errorMessage = "String not null or empty and length is different than permitted";

            var right = new Contract()
                .Requires()
                .HasExactLengthIfNotNullOrEmpty(null, 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasExactLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_Empty()
        {
            var errorMessage = "String not null or empty and length is different than permitted";

            var right = new Contract()
                .Requires()
                .HasExactLengthIfNotNullOrEmpty("", 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void HasExactLengthIfNotNullOrEmpty_Should_ValidAndWithoutNotifications_When_HasExactLength()
        {
            var errorMessage = "String not null or empty and length is different than permitted";

            var right = new Contract()
                .Requires()
                .HasExactLengthIfNotNullOrEmpty("1234567890", 10, "string", errorMessage);

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("ObjectValidation")]
        public void AreEqual_Should_InvalidAndWithNotifications_When_AreNotEqual()
        {
            var wrong = new Contract()
                .AreEquals("String", "String not equals", "object", "Object is not equal");

            Assert.IsTrue(wrong.Invalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("ObjectValidation")]
        public void AreEqual_Should_ValidAndWithoutNotifications_When_AreEqual()
        {
            var right = new Contract()
                .AreEquals("String", "String", "object", "Object is not equal");

            Assert.IsTrue(right.Valid);
            Assert.AreEqual(0, right.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("StringValidation")]
        public void AreNotEquals_Should_ValidAndWithoutNotifications_When_AreNotEqual()
        {
            var right = new Contract()
                .Requires()
                .AreNotEquals("String", "String not equals", "string", "String are equals");

            Assert.AreEqual(true, right.Valid);
        }

        [TestMethod]
        [TestCategory("ObjectValidation")]
        public void AreNotEqual_Should_InvalidAndWithNotifications_When_AreEqual()
        {
            var wrong = new Contract()
                .AreNotEquals("String", "String", "object", "Object is not equal");

            Assert.IsTrue(wrong.Invalid);
            Assert.AreEqual(1, wrong.Notifications.Count);
        }
    }
}
