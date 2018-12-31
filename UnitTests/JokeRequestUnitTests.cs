using FluentAssertions;
using NUnit.Framework;
using PrimesChecker.CodeBehind;

namespace UnitTests
{
    public class JokeRequestUnitTests
    {
        [Test]
        //Test if joke returned value is not null or empty
        public void JokeReturnedValueIsNotNullOrEmpty()
        {
            var sut = new JokesRequest();
            sut.GetTheJoke().Should().NotBeNullOrEmpty();
        }
    }
}