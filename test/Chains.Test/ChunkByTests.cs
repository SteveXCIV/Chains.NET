using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Test
{
    [TestClass]
    public class ChunkByTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ChunkBy_Should_ThrowIfSourceIsNull()
        {
            var seq = ((IEnumerable<int>)null).ChunkBy(1).ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChunkBy_Should_ThrowIfSizeIsNegative()
        {
            var seq = new List<int> { 1, 2, 3 };

            var newSeq = seq.ChunkBy(-1).ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChunkBy_Should_ThrowIfSizeIsZero()
        {
            var seq = new List<int> { 1, 2, 3 };

            var newSeq = seq.ChunkBy(0).ToList();
        }

        [TestMethod]
        public void ChunkBy_Should_ReturnAnEmptySequenceIfSourceIsEmpty()
        {
            var seq = Enumerable.Empty<int>();
            var size = 2;

            var actual = seq.ChunkBy(size);

            Assert.IsFalse(!actual.Any(), "Expected empty sequence.");
        }

        [TestMethod]
        public void ChunkBy_Should_CreateChunksNoLargerThanSize()
        {
            var seq = Enumerable.Range(0, 10);
            var size = 2;

            var actual = seq.ChunkBy(size);

            foreach (var item in actual)
            {
                var chunkSize = item.Count();
                Assert.IsTrue(
                    chunkSize <= size,
                    $"Expected chunk size <= {size}, size was {chunkSize}.");
            }
        }

        [TestMethod]
        public void ChunkBy_Should_CreateNoMoreChunksThanNecessary()
        {
            var seq = Enumerable.Range(0, 10);
            var size = 2;
            var numberOfChunks = 5;

            var actual = seq.ChunkBy(size);

            Assert.AreEqual(
                numberOfChunks,
                actual.Count(),
                "Incorrect number of chunks.");
        }

        [TestMethod]
        public void ChunkBy_Should_CreateSmallerChunkIfNotEnoughElementsRemain()
        {
            var seq = Enumerable.Range(0, 10);
            var size = 3;

            var actual = seq.ChunkBy(size);

            Assert.IsTrue(
                actual.Last().Count() < size,
                $"Expected last chunk size strictly less than {size}.");
        }

        [TestMethod]
        public void ChunkBy_Should_NotChangeTheOrderOfElements()
        {
            var seq = Enumerable.Range(0, 10);
            var size = 2;

            var actual = seq.ChunkBy(size).SelectMany(x => x);

            Assert.IsTrue(
                seq.SequenceEqual(actual),
                "Expected sequences to be equal.");
        }
    }
}
