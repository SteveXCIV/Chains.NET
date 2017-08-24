using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class CompareWithTests
    {
        private const string ExpectedNegative = "Expected a negative integer.";
        private const string ExpectedPositive = "Expected a positive integer.";
        private const string ExpectedZero = "Expected zero.";

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareWith_Should_ThrowIfSourceIsNull()
        {
            IEnumerable<int> first = null;
            IEnumerable<int> second = Enumerable.Range(0, 3);

            var result = first.CompareWith(second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareWith_Should_ThrowIfOtherIsNull()
        {
            IEnumerable<int> first = Enumerable.Range(0, 3);
            IEnumerable<int> second = null;

            var result = first.CompareWith(second);
        }

        [TestMethod]
        public void CompareWith_Should_ReturnNegativeIfFirstSequenceIsLesser()
        {
            var first = new List<int> { 1, 2, 3, 0 };
            var second = new List<int> { 1, 2, 3, 4 };

            Assert.IsTrue(first.CompareWith(second) < 0, ExpectedNegative);
        }

        [TestMethod]
        public void CompareWith_Should_ReturnNegativeIfFirstSequenceIsShorter()
        {
            var first = new List<int> { 1, 2, 3 };
            var second = new List<int> { 1, 2, 3, 4 };

            Assert.IsTrue(first.CompareWith(second) < 0, ExpectedNegative);
        }

        [TestMethod]
        public void CompareWith_Should_ReturnPositiveIfSecondSequenceIsLesser()
        {
            var first = new List<int> { 1, 2, 3, 4 };
            var second = new List<int> { 1, 2, 3, 0 };

            Assert.IsTrue(first.CompareWith(second) > 0, ExpectedPositive);
        }

        [TestMethod]
        public void CompareWith_Should_ReturnPositiveIfSecondSequenceIsShorter()
        {
            var first = new List<int> { 1, 2, 3, 4 };
            var second = new List<int> { 1, 2, 3 };

            Assert.IsTrue(first.CompareWith(second) > 0, ExpectedPositive);
        }

        [TestMethod]
        public void CompareWith_Should_ReturnZeroIfSequencesAreEqual()
        {
            var first = new List<int> { 1, 2, 3, 4 };
            var second = new List<int> { 1, 2, 3, 4 };

            Assert.IsTrue(first.CompareWith(second) == 0, ExpectedZero);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareWithFunc_Should_ThrowIfSourceIsNull()
        {
            IEnumerable<int> first = null;
            IEnumerable<int> second = Enumerable.Range(0, 3);

            var result = first.CompareWith(second, x => (int)x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareWithFunc_Should_ThrowIfOtherIsNull()
        {
            IEnumerable<int> first = Enumerable.Range(0, 3);
            IEnumerable<int> second = null;

            var result = first.CompareWith(second, x => (int)x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareWithFunc_Should_ThrowIfSelectorIsNull()
        {
            IEnumerable<int> first = Enumerable.Range(0, 3);
            IEnumerable<int> second = Enumerable.Range(0, 3);
            Func<int, int> selector = null;

            var result = first.CompareWith(second, selector);
        }

        [TestMethod]
        public void CompareWithFunc_Should_ReturnNegativeIfFirstSequenceIsLesser()
        {
            var first = new List<string> { "1", "2", "3", "0" };
            var second = new List<string> { "1", "2", "3", "4" };

            Assert.IsTrue(first.CompareWith(second, int.Parse) < 0, ExpectedNegative);
        }

        [TestMethod]
        public void CompareWithFunc_Should_ReturnNegativeIfFirstSequenceIsShorter()
        {
            var first = new List<string> { "1", "2", "3" };
            var second = new List<string> { "1", "2", "3", "4" };

            Assert.IsTrue(first.CompareWith(second, int.Parse) < 0, ExpectedNegative);
        }

        [TestMethod]
        public void CompareWithFunc_Should_ReturnPositiveIfSecondSequenceIsLesser()
        {
            var first = new List<string> { "1", "2", "3", "4" };
            var second = new List<string> { "1", "2", "3", "0" };

            Assert.IsTrue(first.CompareWith(second, int.Parse) > 0, ExpectedPositive);
        }

        [TestMethod]
        public void CompareWithFunc_Should_ReturnPositiveIfSecondSequenceIsShorter()
        {
            var first = new List<string> { "1", "2", "3", "4" };
            var second = new List<string> { "1", "2", "3" };

            Assert.IsTrue(first.CompareWith(second, int.Parse) > 0, ExpectedPositive);
        }

        [TestMethod]
        public void CompareWithFunc_Should_ReturnZeroIfSequencesAreEqual()
        {
            var first = new List<string> { "1", "2", "3", "4" };
            var second = new List<string> { "1", "2", "3", "4" };

            Assert.IsTrue(first.CompareWith(second, int.Parse) == 0, ExpectedZero);
        }
    }
}
