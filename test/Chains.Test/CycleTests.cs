using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class CycleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Cycle_Should_ThrowIfSourceIsNull()
        {
            var sequence = (IEnumerable<object>)null;

            var actual = sequence.Cycle().ToList();
        }

        [TestMethod]
        public void Cycle_Should_YieldTheElementsOfAnEnumerableInfinitely()
        {
            var sequence = Enumerable.Range(1, 3);
            var count = 5;
            var expected = new[]{ 1, 2, 3, 1, 2 };

            var actual = sequence.Cycle().Take(count);

            Assert.IsTrue(
                actual.SequenceEqual(expected),
                "Actual and expected sequences did not match.");
        }

        [TestMethod]
        public void Cycle_Should_YieldNothingForAnEmptyEnumerable()
        {
            var sequence = Enumerable.Empty<object>();

            var actual = sequence.Cycle();

            Assert.IsFalse(actual.Any(), "Expected empty sequence.");
        }
    }
}
