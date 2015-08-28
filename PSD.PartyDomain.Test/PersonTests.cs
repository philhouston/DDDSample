using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PSD.PartyDomain.Test
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Person_EmptyGuid_RaisesException()
        {
            var person = new Person(Guid.Empty, new PersonName("Philip", "Houston"));

            Assert.Fail("Expected Exception to be raised");
        }

    }
}
