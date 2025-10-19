using NUnit.Framework;
using EMS.Core.Models;

namespace EMS.Tests.Models
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void User_Properties_SetAndGet_Correctly()
        {
            var user = new User
            {
                Id = 1,
                Username = "testuser",
                Password = "password123",
                CreatedDate = new DateTime(2025, 10, 20)
            };

            Assert.AreEqual(1, user.Id);
            Assert.AreEqual("testuser", user.Username);
            Assert.AreEqual("password123", user.Password);
            Assert.AreEqual(new DateTime(2025, 10, 20), user.CreatedDate);
        }
    }
}
