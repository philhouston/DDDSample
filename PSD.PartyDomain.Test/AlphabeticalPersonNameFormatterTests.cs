using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSD.PartyDomain.Formatters;

namespace PSD.PartyDomain.Test
{
    [TestClass]
    public class AlphabeticalPersonNameFormatterTests
    {
        [TestMethod]
        public void AlphabeticalPersonNameFormatter_WithNoKnownAs_ReturnsExpectedString()
        {
            const string expectedResult = "Houston, Philip";

            var name = new PersonName("Philip", "Houston", "Andrew")
            {
                NameFormatter = new AlphabeticalPersonNameFormatter()
            };

            var actualResult = name.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AlphabeticalPersonNameFormatter_WithKnownAs_ReturnsExpectedString()
        {
            const string expectedResult = "Houston, Phil";

            var name = new PersonName("Philip", "Houston", "Andrew","Phil")
            {
                NameFormatter = new AlphabeticalPersonNameFormatter()
            };

            var actualResult = name.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
