using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PSD.PartyDomain.Test
{
    [TestClass]
    public class PersonNameTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void PersonName_NullFirstName_RaisedException()
        {
            var name = new PersonName(null, "Houston");

            Assert.Fail("Expected Exception to be raised");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void PersonName_EmptyFirstName_RaisedException()
        {
            var name = new PersonName("", "Houston");

            Assert.Fail("Expected Exception to be raised");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void PersonName_NullLastName_RaisedException()
        {
            var name = new PersonName("Phil", null);

            Assert.Fail("Expected Exception to be raised");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void PersonName_EmptyLastName_RaisedException()
        {
            var name = new PersonName("Phil", "");

            Assert.Fail("Expected Exception to be raised");

        }


    }
}
