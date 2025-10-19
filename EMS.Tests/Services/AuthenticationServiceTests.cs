using NUnit.Framework;
using EMS.Core.Services;
using EMS.Core.Models;
using Moq;
using System;

namespace EMS.Tests.Services
{
    [TestFixture]
    public class AuthenticationServiceTests
    {
        [Test]
        public void Authenticate_ReturnsNull_WhenUserNotFound()
        {
            var service = new AuthenticationService();
            var result = service.Authenticate("nonexistent", "wrongpassword");
            Assert.IsNull(result);
        }
    }
}
