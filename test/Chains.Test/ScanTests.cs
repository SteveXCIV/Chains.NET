using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class ScanTests
    {
        public const string ExpectedEmptySequence = "Exected sequence to be empty.";
        public const string ExpectedNonEmptySequence = "Exected sequence not to be empty.";
        public const string ExpectedSizeMismatch = "Sequence sizes differed.";
        public const string ExpectedElementMismatch = "Sequence element did not match expectation.";

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Scan2_Should_ThrowIfSourceIsNull()
        {
            var sequence = (IEnumerable<object>)null;

            var actual = sequence
                .Scan((x, y) => x)
                .ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Scan2_Should_ThrowIfAccumulatorIsNull()
        {
            var sequence = Enumerable.Range(1, 3);

            var actual = sequence
                .Scan((Func<int, int, int>)null)
                .ToList();
        }

        [TestMethod]
        public void Scan2_Should_ProduceAnEmptySequenceIfSourceIsEmpty()
        {
            var sequence = Enumerable.Empty<object>();

            var actual = sequence
                .Scan((x, y) => x);

            Assert.IsFalse(actual.Any(), ExpectedEmptySequence);
        }

        [TestMethod]
        public void Scan2_Should_ProduceTheExpectedElements()
        {
            var sequence = new[]{ 1, 2, 3 };
            var expected = new[]{ 1, 3, 6 };

            var actual = sequence
                .Scan((x, y) => x + y);

            Assert.AreEqual(expected.Length, actual.Count(), ExpectedSizeMismatch);
            Assert.IsTrue(actual.SequenceEqual(expected), ExpectedElementMismatch);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Scan3_Should_ThrowIfSourceIsNull()
        {
            var sequence = (IEnumerable<object>)null;

            var actual = sequence
                .Scan(new object(), (x, y) => x)
                .ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Scan3_Should_ThrowIfAccumulatorIsNull()
        {
            var sequence = Enumerable.Range(1, 3);

            var actual = sequence
                .Scan(0, (Func<int, int, int>)null)
                .ToList();
        }

        [TestMethod]
        public void Scan3_Should_YieldTheSeedValueIfSourceIsEmpty()
        {
            var sequence = Enumerable.Empty<int>();
            var seed = 1;

            var actual = sequence
                .Scan(seed, (x, y) => x);

            Assert.AreEqual(1, actual.Count(), ExpectedNonEmptySequence);
            Assert.AreEqual(seed, actual.First(), ExpectedElementMismatch);
        }

        [TestMethod]
        public void Scan3_Should_ProduceTheExpectedElements()
        {
            var sequence = new[]{ 1, 2, 3 };
            var seed = 0;
            var expected = new[]{ seed, 1, 3, 6 };

            var actual = sequence
                .Scan(seed, (x, y) => x + y);

            Assert.AreEqual(expected.Length, actual.Count(), ExpectedSizeMismatch);
            Assert.IsTrue(actual.SequenceEqual(expected), ExpectedElementMismatch);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Scan4_Should_ThrowIfSourceIsNull()
        {
            var sequence = (IEnumerable<object>)null;

            var actual = sequence
                .Scan(new object(), (x, y) => x, x => x)
                .ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Scan4_Should_ThrowIfAccumulatorIsNull()
        {
            var sequence = Enumerable.Range(1, 3);

            var actual = sequence
                .Scan(0, (Func<int, int, int>)null, x => x)
                .ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Scan4_Should_ThrowIfTransformerIsNull()
        {
            var sequence = Enumerable.Range(1, 3);

            var actual = sequence
                .Scan(0, (x, y) => x, (Func<int, int>)null)
                .ToList();
        }

        [TestMethod]
        public void Scan4_Should_YieldTheTransformedSeedValueIfSourceIsEmpty()
        {
            var sequence = Enumerable.Empty<int>();
            var seed = 1;
            var expected = 3;

            var actual = sequence
                .Scan(seed, (x, y) => x, x => expected);

            Assert.AreEqual(1, actual.Count(), ExpectedNonEmptySequence);
            Assert.AreEqual(expected, actual.First(), ExpectedElementMismatch);
        }

        [TestMethod]
        public void Scan4_Should_ProduceTheExpectedElements()
        {
            var sequence = new[]{ 1, 2, 3 };
            var seed = 0;
            var offset = 2;
            var expected = new[]{ offset, 3, 5, 8 };

            var actual = sequence
                .Scan(seed, (x, y) => x + y, x => x + offset);

            Assert.AreEqual(expected.Length, actual.Count(), ExpectedSizeMismatch);
            Assert.IsTrue(actual.SequenceEqual(expected), ExpectedElementMismatch);
        }
    }
}
