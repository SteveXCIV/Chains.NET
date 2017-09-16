using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class ForEachTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ForEach_Should_ThrowIfSourceIsNull()
        {
            IEnumerable<int> seq = null;

            seq.ForEach(Console.WriteLine);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ForEach_Should_ThrowIfActionIsNull()
        {
            var seq = Enumerable.Range(0, 10);
            Action<int> action = null;

            seq.ForEach(action);
        }

        [TestMethod]
        public void ForEach_Should_ExecuteTheActionForEachItem()
        {
            var count = 0;
            var expected = 6;
            var seq = Enumerable.Range(0, 4);
            void Increment(int i) => count += i;

            seq.ForEach(Increment);

            Assert.AreEqual(expected, count, "Did not produce expected value.");
        }
    }
}
