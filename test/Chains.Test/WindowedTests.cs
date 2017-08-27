using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class WindowedTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Windowed_Should_ThrowIfSourceIsNull()
        {
            var sequence = (IEnumerable<object>)null;

            var actual = sequence.Windowed(1).ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Windowed_Should_ThrowIfSizeIsZero()
        {
            var sequence = Enumerable.Range(0, 10);
            var size = 0;

            var actual = sequence.Windowed(size).ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Windowed_Should_ThrowIfSizeIsNegative()
        {
            var sequence = Enumerable.Range(0, 10);
            var size = -1;

            var actual = sequence.Windowed(size).ToList();
        }

        [TestMethod]
        public void Windowed_Should_ProduceAnEmptySequenceIfNotEnoughElements()
        {
            var sequence = Enumerable.Range(1, 1);
            var size = 2;

            var actual = sequence.Windowed(size);

            Assert.IsFalse(actual.Any(), "Expected empty sequence.");
        }

        [TestMethod]
        public void Windowed_Should_ProduceFixedSizeWindowsUntilEnd()
        {
            var sequence = new[]{ 1, 2, 3, 4, 5 };
            var size = 3;
            var expected = new List<int[]> {
                new[]{ 1, 2, 3 },
                new[]{ 2, 3, 4 },
                new[]{ 3, 4, 5 }
            };

            var actual = sequence.Windowed(size);

            Assert.AreEqual(expected.Count, actual.Count(), "Mismatched counts.");
            foreach (var window in actual)
                Assert.AreEqual(size, window.Count(), "Mismatched counts.");
            Assert.IsTrue(
                expected
                    .SelectMany(x => x)
                    .SequenceEqual(actual.SelectMany(x => x)),
                "Expected sequences to match.");
        }
    }
}
