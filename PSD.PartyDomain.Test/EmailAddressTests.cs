using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PSD.PartyDomain.Test
{
    [TestClass]
    public class EmailddressTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmailAddress_NullEmail_RaisesException()
        {
            var address = new EmailAddress(null, "Test");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmailAddress_EmptyEmail_RaisesException()
        {
            var address = new EmailAddress("", "Test");

            Assert.Fail("Expected Exception to be raised");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmailAddress_NullPurpose_RaisesException()
        {
            var address = new EmailAddress("someone@somewhere.com", null);

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmailAddress_EmptyPurpose_RaisesException()
        {
            var address = new EmailAddress("www.someplace.com", "");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmailAddress_InvalidEmail_RaisesException()
        {
            var address = new EmailAddress("www.someplace.com", "Test");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        public void EmailAddress_ValidEmail_CreateObject()
        {
            var address = new EmailAddress("someone@someplace.com", "Test");

            Assert.IsNotNull(address);

        }


        [TestMethod]
        public void EmailAddress_TwoAddressesSameValue_AreEqual()
        {
            var address = new EmailAddress("someone@somewhere.com", "test");
            var address2 = new EmailAddress("someone@somewhere.com", "test");

            Assert.IsTrue(address == address2);
        }

        [TestMethod]
        public void EmailAddress_TwoAddressesDifferentValue_AreNotEqual()
        {
            var address = new EmailAddress("someone@somewhere.com", "test");
            var address2 = new EmailAddress("someoneelse@somewhere.com", "test");

            Assert.IsTrue(address != address2);
        }




    }
}

