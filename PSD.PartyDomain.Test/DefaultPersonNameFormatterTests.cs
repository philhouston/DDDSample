using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSD.PartyDomain.Formatters;

namespace PSD.PartyDomain.Test
{
    [TestClass]
    public class DefaultPersonNameFormatterTests
    {
        [TestMethod]
        public void DefaultPersonNameFormatter_WithNoKnownAs_ReturnsExpectedString()
        {
            const string expectedResult = "Philip Houston";

            var name = new PersonName("Philip", "Houston", "Andrew")
            {
                NameFormatter = new DefaultPersonNameFormatter()
            };

            var actualResult = name.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DefaultPersonNameFormatter_WithKnownAs_ReturnsExpectedString()
        {
            const string expectedResult = "Phil Houston";

            var name = new PersonName("Philip", "Houston", "Andrew","Phil")
            {
                NameFormatter = new DefaultPersonNameFormatter()
            };

            var actualResult = name.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
