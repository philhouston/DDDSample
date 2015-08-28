using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PSD.PartyDomain.Test
{
    [TestClass]
    public class RegisteredIdentifierTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RegisteredIdentifier_NullIdentifier_RaisesException()
        {
            var identifer = new RegisteredIdentifier(null, "Passport", "UK");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RegisteredIdentifier_EmptyIdentifier_RaisesException()
        {
            var identifer = new RegisteredIdentifier("", "Passport", "UK");

            Assert.Fail("Expected Exception to be raised");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RegisteredIdentifier_EmptyIdentifierType_RaisesException()
        {
            var identifer = new RegisteredIdentifier("AB12345", "", "UK");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RegisteredIdentifier_EmptyIssuedBy_RaisesException()
        {
            var identifer = new RegisteredIdentifier("AB12345", "Passport", "");

            Assert.Fail("Expected Exception to be raised");
        }

        [TestMethod]
        public void RegisteredIdentifier_ValidFromDate_IsRecordedAsExpected()
        {
            DateTime expectedValidFrom = new DateTime(2000,10,15);

            var identifer = new RegisteredIdentifier("AB12345", "Passport", "UK", expectedValidFrom);

            Assert.AreEqual(expectedValidFrom, identifer.ValidFrom);
        }

        [TestMethod]
        public void RegisteredIdentifier_ValidToDate_IsRecordedAsExpected()
        {
            DateTime expectedValidTo = new DateTime(2010, 10, 15);

            var identifer = new RegisteredIdentifier("AB12345", "Passport", "UK", new DateTime(2000,10,15), expectedValidTo);

            Assert.AreEqual(expectedValidTo, identifer.ValidTo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RegisteredIdentifier_ValidToDateWithNullFromDate_RaisesException()
        {
            DateTime expectedValidTo = new DateTime(2010, 10, 15);

            var identifer = new RegisteredIdentifier("AB12345", "Passport", "UK", null, expectedValidTo);

            Assert.Fail("Expected exception to be raised");
        }



    }
}
