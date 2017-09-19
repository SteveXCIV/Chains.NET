using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class ExceptLastTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptLast_Should_ThrowIfSourceIsNull()
        {
            var sequence = (IEnumerable<object>)null;

            var actual = sequence.ExceptLast().ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptLast_Should_ThrowIfSourceIsEmpty()
        {
            var sequence = Enumerable.Empty<object>();

            var actual = sequence.ExceptLast().ToList();
        }

        [TestMethod]
        public void ExceptLast_Should_YieldAllElementsExceptTheLast()
        {
            var sequence = Enumerable.Range(1, 3);
            var expected = new[]{ 1, 2 };

            var actual = sequence.ExceptLast();

            Assert.IsTrue(
                actual.SequenceEqual(expected),
                "Actual and expected sequences did not match.");
        }

        [TestMethod]
        public void ExceptLast_Should_BeTheInverseOfLast()
        {
            var sequence = Enumerable.Range(1, 3);

            var last = sequence.Last();
            var exceptLast = sequence.ExceptLast();
            var concat = exceptLast.Append(last);

            Assert.IsTrue(
                concat.SequenceEqual(sequence),
                "Inverse constraint failed.");
        }

    }
}
