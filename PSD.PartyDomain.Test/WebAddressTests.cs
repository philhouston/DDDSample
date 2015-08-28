using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PSD.PartyDomain.Test
{
    [TestClass]
    public class WebAddressTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WebAddress_NullUrl_RaisesException()
        {
            var address = new WebAddress(null, "Test");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WebAddress_EmptyUrl_RaisesException()
        {
            var address = new WebAddress("", "Test");

            Assert.Fail("Expected Exception to be raised");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WebAddress_NullPurpose_RaisesException()
        {
            var address = new WebAddress("http://www.someplace.com", null);

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WebAddress_EmptyPurpose_RaisesException()
        {
            var address = new WebAddress("http://www.someplace.com", "");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WebAddress_InvalidUrl_RaisesException()
        {
            var address = new WebAddress("www.somerubbish", "test");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        public void WebAddress_httpsWebAddress_IsValid()
        {
            var address = new WebAddress("https://www.google.com", "test");

            Assert.IsNotNull(address);
        }

        [TestMethod]
        public void WebAddress_httpWebAddress_IsValid()
        {
            var address = new WebAddress("http://www.google.com", "test");

            Assert.IsNotNull(address);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WebAddress_wwwWebAddress_IsNotValid()
        {
            var address = new WebAddress("www.google.com", "test");

            Assert.IsNotNull(address);
        }

        [TestMethod]
        public void WebAddress_ValidWebAddress_IsReachable()
        {
            var address = new WebAddress("http://www.google.com", "test");

            Assert.IsTrue(address.UrlReachable());
        }

        [TestMethod]
        public void WebAddress_InvalidWebAddress_IsNotReachable()
        {
            var address = new WebAddress("http://www.somerubishendpoint.com", "test");

            Assert.IsFalse(address.UrlReachable());
        }


        [TestMethod]
        public void WebAddress_TwoAddressesSameValue_AreEqual()
        {
            var address = new WebAddress("http://www.google.com", "test");
            var address2 = new WebAddress("http://www.google.com", "test");

            Assert.IsTrue(address == address2);
        }

        [TestMethod]
        public void WebAddress_TwoAddressesDifferentValue_AreNotEqual()
        {
            var address = new WebAddress("http://www.google2.com", "test");
            var address2 = new WebAddress("http://www.google.com", "test");

            Assert.IsTrue(address != address2);
        }




    }
}
