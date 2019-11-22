using System;
using Xunit;

namespace Common.Tests
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            var actual = handler.InsertSpaces(source);

            Assert.Equal(expected, actual);
        }
    }
}
