using System.Collections;
using System.Linq;
using Ploeh.AutoFixture;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture.AutoMoq;

namespace B3nCr.Auth.Test
{
    [TestClass]
    public class AuthServiceTests
    {

        [TestMethod]
        public void MyTestMethod()
        {
            var f = new Fixture().Customize(new AutoMoqCustomization());

            var sut = f.Create<AuthenticationService>();
        }
        [TestMethod]
        public void TestRegister()
        {
            var f = new Fixture().Customize(new AutoMoqCustomization());
            
            var sut = f.Create<AuthenticationService>();
            var model  = f.CreateAnonymous<RegistrationModel>();

            sut.Register(model);

            Assert.AreEqual(1, sut.Users.Count());
        }
    }
}
