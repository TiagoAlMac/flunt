using Flunt.Notifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Tests
{
    [TestClass]
    public class NotifiableTests : Notifiable
    {
        [TestMethod]
        [TestCategory("Notifiable")]
        public void AddNotification_Must_Add_When_OneByOne()
        {
            var name =new Name();
            var cus = new Customer();

            AddNotifications(name);
            AddNotifications(cus);

            Assert.AreEqual(false, Valid);
            Assert.AreEqual(2, Notifications.Count);            
        }

        [TestMethod]
        [TestCategory("Notifiable")]
        public void AddNotification_Must_Add_When_AllAtOnce()
        {
            var name = new Name();
            var customer = new Customer();

            AddNotifications(name, customer);

            Assert.AreEqual(false, Valid);
            Assert.AreEqual(2, Notifications.Count);
        }
    }

    public class Customer : Notifiable
    {
        public Customer()
        {
            AddNotification("Test", "Testing");
        }

        public Name Name { get; set; }
    }

    public class Name : Notifiable
    {
        public Name()
        {
            AddNotification("Test", "Testing");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
