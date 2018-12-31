using FluentAssertions;
using NUnit.Framework;
using PrimesChecker.CodeBehind;

namespace UnitTests
{
    public class PrimesUnitTests
    {
        //These tests are parametrized

        [Test]
        //Tests if the algorithm works correctly taking the first prime 2, and a random large prime, and some random prime in the middle
        public void PassingPrimeNumbersAlgorithmReturnsTrue([Values(982451653, 2, 167)] double num)
        {
            var sut = new PrimesAlgorithm();
            sut.Primes(num).Should().BeTrue();
        }

        [Test]
        //Tests a big number, negative values, special cases 0 and 1, and every number who has a factor from 2 - 10.
        public void PassingNotPrimeNumbersAlgorithmReturnsFalse([Values(9999999999999999944, -1, 0, 1, 4, 9, 15, 16, 49, 64, 81, 100)] double num)
        {
            var sut = new PrimesAlgorithm();
            sut.Primes(num).Should().BeFalse();
        }
    }
}
