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

            var actual = StringHandler.InsertSpaces(source);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            var actual = StringHandler.InsertSpaces(source);

            Assert.Equal(expected, actual);
        }
    }
}
