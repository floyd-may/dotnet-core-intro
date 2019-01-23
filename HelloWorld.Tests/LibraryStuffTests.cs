using System;
using Xunit;
using HelloWorld.Lib;
using FluentAssertions;

namespace HelloWorld.Tests
{
    public class LibraryStuffTests
    {
        [Fact]
        public void TwoPlusTwo()
        {
            LibraryStuff.Add(2, 2)
                .Should()
                .Be(5);
        }
    }
}
