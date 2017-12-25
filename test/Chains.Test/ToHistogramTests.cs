using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class ToHistogramTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ToHistogram_Should_ThrowIfSourceIsNull()
        {
            var seq = ((IEnumerable<int>)null).ToHistogram();
        }

        [TestMethod]
        public void ToHistogram_Should_ReturnAnEmptyDictionaryIfSourceIsEmpty()
        {
            var seq = Enumerable.Empty<int>();

            var actual = seq.ToHistogram();

            Assert.IsFalse(actual.Any(), "Expected empty dictionary.");
        }

        [TestMethod]
        public void ToHistogram_Should_GenerateCountsOfUniqueValues()
        {
            var seq = new[] { 1, 2, 3, 1, 2, 1 };

            var actual = seq.ToHistogram();

            Assert.IsTrue(actual.ContainsKey(1), "Expected key 1 to exist.");
            Assert.AreEqual(actual[1], 3, "Expected 3 occurrences of key 1.");
            Assert.IsTrue(actual.ContainsKey(2), "Expected key 2 to exist.");
            Assert.AreEqual(actual[2], 2, "Expected 2 occurrences of key 2.");
            Assert.IsTrue(actual.ContainsKey(3), "Expected key 3 to exist.");
            Assert.AreEqual(actual[3], 1, "Expected 1 occurence of key 3.");
        }
    }
}
