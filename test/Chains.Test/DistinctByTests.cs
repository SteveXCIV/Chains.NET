using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class DistinctByTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DistinctBy_Should_ThrowIfSourceIsNull()
        {
            var seq = ((IEnumerable<int>)null).DistinctBy(x => x).ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DistinctBy_Should_ThrowIfKeySelectorIsNull()
        {
            var seq = new List<int> { 1, 2, 3 };

            var newSeq = seq.DistinctBy((Func<int, int>)null).ToList();
        }

        [TestMethod]
        public void DistinctBy_Should_SelectValuesByKey()
        {
            var seq = new List<int> { 1, 2, 3, 4 };
            var expected = new List<int> { 1, 2 };

            var actual = seq.DistinctBy(x => x % 2);

            foreach (var item in actual)
                Assert.IsTrue(
                    expected.Contains(item),
                    $"Expected {item} in sequence.");
        }
    }
}
