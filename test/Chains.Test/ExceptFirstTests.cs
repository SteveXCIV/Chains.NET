using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class ExceptFirstTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptFirst_Should_ThrowIfSourceIsNull()
        {
            var sequence = (IEnumerable<object>)null;

            var actual = sequence.ExceptFirst().ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExceptFirst_Should_ThrowIfSourceIsEmpty()
        {
            var sequence = Enumerable.Empty<object>();

            var actual = sequence.ExceptFirst().ToList();
        }

        [TestMethod]
        public void ExceptFirst_Should_YieldAllElementsExceptTheFirst()
        {
            var sequence = Enumerable.Range(1, 3);
            var expected = new[]{ 2, 3 };

            var actual = sequence.ExceptFirst();

            Assert.IsTrue(
                actual.SequenceEqual(expected),
                "Actual and expected sequences did not match.");
        }

        [TestMethod]
        public void ExceptFirst_Should_BeTheInverseOfFirst()
        {
            var sequence = Enumerable.Range(1, 3);

            var first = new[]{ sequence.First() };
            var exceptFirst = sequence.ExceptFirst();
            var concat = first.Concat(exceptFirst);

            Assert.IsTrue(
                concat.SequenceEqual(sequence),
                "Inverse constraint failed.");
        }

    }
}
