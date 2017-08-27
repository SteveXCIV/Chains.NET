using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class RequirementHelperTests
    {
        private const string DidNotReturnSameReference = "Did not return the same reference.";
        private const string DidNotReturnEqualValue = "Did not return equal value.";

        [TestMethod]
        public void EnsureNotNull_Should_ReturnSameObjectIfNotNull()
        {
            var expected = "Hello, world!";

            var actual = expected.EnsureNotNull(nameof(expected));

            Assert.AreSame(expected, actual, DidNotReturnSameReference);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EnsureNotNull_Should_ThrowIfNull()
        {
            var expected = (string)null;

            var actual = expected.EnsureNotNull(nameof(expected));
        }

        [TestMethod]
        public void EnsureBetweenInclusive_Should_ReturnSameObjectIfBetweenInclusive()
        {
            var expected = 5;
            var min = 0;
            var max = 10;

            var actual = expected.EnsureBetweenInclusive(min, max, nameof(expected));

            Assert.AreEqual(expected, actual, DidNotReturnEqualValue);
        }

        [TestMethod]
        public void EnsureBetweenInclusive_Should_NotThrowIfEqualToMinimum()
        {
            var expected = 0;
            var min = 0;
            var max = 10;

            var actual = expected.EnsureBetweenInclusive(min, max, nameof(expected));

            Assert.AreEqual(expected, actual, DidNotReturnEqualValue);
        }

        [TestMethod]
        public void EnsureBetweenInclusive_Should_NotThrowIfEqualToMaximum()
        {
            var expected = 10;
            var min = 0;
            var max = 10;

            var actual = expected.EnsureBetweenInclusive(min, max, nameof(expected));

            Assert.AreEqual(expected, actual, DidNotReturnEqualValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureBetweenInclusive_Should_ThrowIfLessThanMinimum()
        {
            var expected = -1;
            var min = 0;
            var max = 10;

            var actual = expected.EnsureBetweenInclusive(min, max, nameof(expected));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureBetweenInclusive_Should_ThrowIfGreaterThanMaximum()
        {
            var expected = 11;
            var min = 0;
            var max = 10;

            var actual = expected.EnsureBetweenInclusive(min, max, nameof(expected));
        }

        [TestMethod]
        public void EnsureGreaterThan_Should_ReturnSameObjectIfGreaterThanOther()
        {
            var expected = "abc";
            var other = "aaa";

            var actual = expected.EnsureGreaterThan(other, nameof(expected));

            Assert.AreSame(expected, actual, DidNotReturnSameReference);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureGreaterThan_Should_ThrowIfEqualToOther()
        {
            var expected = "abc";
            var other = "abc";

            var actual = expected.EnsureGreaterThan(other, nameof(expected));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureGreaterThan_Should_ThrowIfLesserThanOther()
        {
            var expected = "abc";
            var other = "zzz";

            var actual = expected.EnsureGreaterThan(other, nameof(expected));
        }

        [TestMethod]
        public void EnsureLessThan_Should_ReturnSameObjectIfLessserThanOther()
        {
            var expected = "abc";
            var other = "zzz";

            var actual = expected.EnsureLessThan(other, nameof(expected));

            Assert.AreSame(expected, actual, DidNotReturnSameReference);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureLessThan_Should_ThrowIfEqualToOther()
        {
            var expected = "abc";
            var other = "abc";

            var actual = expected.EnsureLessThan(other, nameof(expected));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EnsureLessThan_Should_ThrowIfGreaterThanOther()
        {
            var expected = "abc";
            var other = "aaa";

            var actual = expected.EnsureLessThan(other, nameof(expected));
        }

        [TestMethod]
        public void Ensure_Should_ReturnSameInstanceIfRequirmentPassed()
        {
            var expected = "Hello, world.";

            var actual = expected.Ensure(s => true, nameof(expected), "Did not pass expectation.");

            Assert.AreSame(expected, actual, DidNotReturnEqualValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Ensure_Should_ThrowIfRequirementFailed()
        {
            var expected = "Hello, world!";

            var actual = expected.Ensure(s => false, nameof(expected), "Passed expectation.");
        }
    }
}
