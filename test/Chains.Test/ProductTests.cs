using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chains;

namespace Chains.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductOfInts_Should_ComputeTheProduct()
        {
            var ints = new[]{ 1, 2, 3 };
            var expected = 1 * 2 * 3;

            var actual = ints.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfInts_Should_ReturnOneForEmptySequence()
        {
            var ints = Enumerable.Empty<int>();
            var expected = 1;

            var actual = ints.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfInts_Should_ThrowForNullSequence()
        {
            var ints = (IEnumerable<int>)null;

            var actual = ints.Product();
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfInts_Should_ThrowOnOverflow()
        {
            var ints = new[]{ int.MaxValue, 10 };

            var actual = ints.Product();
        }

        [TestMethod]
        public void ProductOfNullableInts_Should_ComputeTheProduct()
        {
            var ints = new int?[]{ 1, 2, 3 };
            var expected = (int?)(1 * 2 * 3);

            var actual = ints.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableInts_Should_IgnoreNullValues()
        {
            var ints = new int?[]{ 1, null, 2, null, 3, null };
            var expected = (int?)(1 * 2 * 3);

            var actual = ints.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableInts_Should_ReturnOneForEmptySequence()
        {
            var ints = Enumerable.Empty<int?>();
            var expected = (int?)1;

            var actual = ints.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfNullableInts_Should_ThrowForNullSequence()
        {
            var ints = (IEnumerable<int?>)null;

            var actual = ints.Product();
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfNullableInts_Should_ThrowOnOverflow()
        {
            var ints = new int?[]{ int.MaxValue, 10 };

            var actual = ints.Product();
        }

        [TestMethod]
        public void ProductOfLongs_Should_ComputeTheProduct()
        {
            var longs = new[]{ 1L, 2L, 3L };
            var expected = 1L * 2L * 3L;

            var actual = longs.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfLongs_Should_ReturnOneForEmptySequence()
        {
            var longs = Enumerable.Empty<long>();
            var expected = 1L;

            var actual = longs.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfLongs_Should_ThrowForNullSequence()
        {
            var longs = (IEnumerable<long>)null;

            var actual = longs.Product();
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfLongs_Should_ThrowOnOverflow()
        {
            var longs = new[]{ long.MaxValue, 10L };

            var actual = longs.Product();
        }

        [TestMethod]
        public void ProductOfNullableLongs_Should_ComputeTheProduct()
        {
            var longs = new long?[]{ 1L, 2L, 3L };
            var expected = (long?)(1L * 2L * 3L);

            var actual = longs.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableLongs_Should_IgnoreNullValues()
        {
            var longs = new long?[]{ 1L, null, 2L, null, 3L, null };
            var expected = (long?)(1L * 2L * 3L);

            var actual = longs.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableLongs_Should_ReturnOneForEmptySequence()
        {
            var longs = Enumerable.Empty<long?>();
            var expected = (long?)1L;

            var actual = longs.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfNullableLongs_Should_ThrowForNullSequence()
        {
            var longs = (IEnumerable<long?>)null;

            var actual = longs.Product();
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfNullableLongs_Should_ThrowOnOverflow()
        {
            var longs = new long?[]{ long.MaxValue, 10L };

            var actual = longs.Product();
        }

        [TestMethod]
        public void ProductOfFloats_Should_ComputeTheProduct()
        {
            var floats = new[]{ 1.0F, 2.0F, 3.0F };
            var expected = 1.0F * 2.0F * 3.0F;

            var actual = floats.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfFloats_Should_ReturnOneForEmptySequence()
        {
            var floats = Enumerable.Empty<float>();
            var expected = 1.0F;

            var actual = floats.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfFloats_Should_ThrowForNullSequence()
        {
            var floats = (IEnumerable<float>)null;

            var actual = floats.Product();
        }

        [TestMethod]
        public void ProductOfNullableFloats_Should_ComputeTheProduct()
        {
            var floats = new float?[]{ 1.0F, 2.0F, 3.0F };
            var expected = (float?)(1.0F * 2.0F * 3.0F);

            var actual = floats.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableFloats_Should_IgnoreNullValues()
        {
            var floats = new float?[]{ 1.0F, null, 2.0F, null, 3.0F, null };
            var expected = (float?)(1.0F * 2.0F * 3.0F);

            var actual = floats.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableFloats_Should_ReturnOneForEmptySequence()
        {
            var floats = Enumerable.Empty<float?>();
            var expected = (float?)1.0F;

            var actual = floats.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfNullableFloats_Should_ThrowForNullSequence()
        {
            var floats = (IEnumerable<float?>)null;

            var actual = floats.Product();
        }

        [TestMethod]
        public void ProductOfDoubles_Should_ComputeTheProduct()
        {
            var doubles = new[]{ 1.0, 2.0, 3.0 };
            var expected = 1.0 * 2.0 * 3.0;

            var actual = doubles.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfDoubles_Should_ReturnOneForEmptySequence()
        {
            var doubles = Enumerable.Empty<double>();
            var expected = 1.0;

            var actual = doubles.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfDoubles_Should_ThrowForNullSequence()
        {
            var doubles = (IEnumerable<double>)null;

            var actual = doubles.Product();
        }

        [TestMethod]
        public void ProductOfNullableDoubles_Should_ComputeTheProduct()
        {
            var doubles = new double?[]{ 1.0, 2.0, 3.0 };
            var expected = (double?)(1.0 * 2.0 * 3.0);

            var actual = doubles.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableDoubles_Should_IgnoreNullValues()
        {
            var doubles = new double?[]{ 1.0, null, 2.0, null, 3.0, null };
            var expected = (double?)(1.0 * 2.0 * 3.0);

            var actual = doubles.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableDoubles_Should_ReturnOneForEmptySequence()
        {
            var doubles = Enumerable.Empty<double?>();
            var expected = (double?)1.0;

            var actual = doubles.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfNullableDoubles_Should_ThrowForNullSequence()
        {
            var doubles = (IEnumerable<double?>)null;

            var actual = doubles.Product();
        }

        [TestMethod]
        public void ProductOfDecimals_Should_ComputeTheProduct()
        {
            var decimals = new[]{ 1.0M, 2.0M, 3.0M };
            var expected = 1.0M * 2.0M * 3.0M;

            var actual = decimals.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfDecimals_Should_ReturnOneForEmptySequence()
        {
            var decimals = Enumerable.Empty<decimal>();
            var expected = 1.0M;

            var actual = decimals.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfDecimals_Should_ThrowForNullSequence()
        {
            var decimals = (IEnumerable<decimal>)null;

            var actual = decimals.Product();
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfDecimals_Should_ThrowOnOverflow()
        {
            var decimals = new[]{ decimal.MaxValue, 10.0M };

            var actual = decimals.Product();
        }

        [TestMethod]
        public void ProductOfNullableDecimals_Should_ComputeTheProduct()
        {
            var decimals = new decimal?[]{ 1.0M, 2.0M, 3.0M };
            var expected = (decimal?)(1.0M * 2.0M * 3.0M);

            var actual = decimals.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableDecimals_Should_IgnoreNullValues()
        {
            var decimals = new decimal?[]{ 1.0M, null, 2.0M, null, 3.0M, null };
            var expected = (decimal?)(1.0M * 2.0M * 3.0M);

            var actual = decimals.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfNullableDecimals_Should_ReturnOneForEmptySequence()
        {
            var decimals = Enumerable.Empty<decimal?>();
            var expected = (decimal?)1.0M;

            var actual = decimals.Product();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfNullableDecimals_Should_ThrowForNullSequence()
        {
            var decimals = (IEnumerable<decimal?>)null;

            var actual = decimals.Product();
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfNullableDecimals_Should_ThrowOnOverflow()
        {
            var decimals = new decimal?[]{ decimal.MaxValue, 10.0M };

            var actual = decimals.Product();
        }

        [TestMethod]
        public void ProductOfTransformedInts_Should_ComputeTheProduct()
        {
            var ints = new[]{ 1, 2, 3 };
            var expected = 1 * 2 * 3;

            var actual = ints.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedInts_Should_ReturnOneForEmptySequence()
        {
            var ints = Enumerable.Empty<int>();
            var expected = 1;

            var actual = ints.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedInts_Should_ThrowForNullSequence()
        {
            var ints = (IEnumerable<int>)null;

            var actual = ints.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedInts_Should_ThrowForNullSelector()
        {
            var ints = new[]{ 1, 2, 3 };

            var actual = ints.Product((Func<int, int>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfTransformedInts_Should_ThrowOnOverflow()
        {
            var ints = new[]{ int.MaxValue, 10 };

            var actual = ints.Product(x => x);
        }

        [TestMethod]
        public void ProductOfTransformedNullableInts_Should_ComputeTheProduct()
        {
            var ints = new int?[]{ 1, 2, 3 };
            var expected = (int?)(1 * 2 * 3);

            var actual = ints.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableInts_Should_IgnoreNullValues()
        {
            var ints = new int?[]{ 1, null, 2, null, 3, null };
            var expected = (int?)(1 * 2 * 3);

            var actual = ints.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableInts_Should_ReturnOneForEmptySequence()
        {
            var ints = Enumerable.Empty<int?>();
            var expected = (int?)1;

            var actual = ints.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableInts_Should_ThrowForNullSequence()
        {
            var ints = (IEnumerable<int?>)null;

            var actual = ints.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableInts_Should_ThrowForNullSelector()
        {
            var ints = new int?[]{ 1, 2, 3 };

            var actual = ints.Product((Func<int?, int?>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfTransformedNullableInts_Should_ThrowOnOverflow()
        {
            var ints = new int?[]{ int.MaxValue, 10 };

            var actual = ints.Product(x => x);
        }

        [TestMethod]
        public void ProductOfTransformedLongs_Should_ComputeTheProduct()
        {
            var longs = new[]{ 1L, 2L, 3L };
            var expected = 1L * 2L * 3L;

            var actual = longs.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedLongs_Should_ReturnOneForEmptySequence()
        {
            var longs = Enumerable.Empty<long>();
            var expected = 1L;

            var actual = longs.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedLongs_Should_ThrowForNullSequence()
        {
            var longs = (IEnumerable<long>)null;

            var actual = longs.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedLongs_Should_ThrowForNullSelector()
        {
            var longs = new[]{ 1L, 2L, 3L };

            var actual = longs.Product((Func<long, long>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfTransformedLongs_Should_ThrowOnOverflow()
        {
            var longs = new[]{ long.MaxValue, 10L };

            var actual = longs.Product(x => x);
        }

        [TestMethod]
        public void ProductOfTransformedNullableLongs_Should_ComputeTheProduct()
        {
            var longs = new long?[]{ 1L, 2L, 3L };
            var expected = (long?)(1L * 2L * 3L);

            var actual = longs.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableLongs_Should_IgnoreNullValues()
        {
            var longs = new long?[]{ 1L, null, 2L, null, 3L, null };
            var expected = (long?)(1L * 2L * 3L);

            var actual = longs.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableLongs_Should_ReturnOneForEmptySequence()
        {
            var longs = Enumerable.Empty<long?>();
            var expected = (long?)1L;

            var actual = longs.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableLongs_Should_ThrowForNullSequence()
        {
            var longs = (IEnumerable<long?>)null;

            var actual = longs.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableLongs_Should_ThrowForNullSelector()
        {
            var longs = new long?[]{ 1L, 2L, 3L };

            var actual = longs.Product((Func<long?, long?>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfTransformedNullableLongs_Should_ThrowOnOverflow()
        {
            var longs = new long?[]{ long.MaxValue, 10L };

            var actual = longs.Product(x => x);
        }

        [TestMethod]
        public void ProductOfTransformedFloats_Should_ComputeTheProduct()
        {
            var floats = new[]{ 1.0F, 2.0F, 3.0F };
            var expected = 1.0F * 2.0F * 3.0F;

            var actual = floats.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedFloats_Should_ReturnOneForEmptySequence()
        {
            var floats = Enumerable.Empty<float>();
            var expected = 1.0F;

            var actual = floats.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedFloats_Should_ThrowForNullSequence()
        {
            var floats = (IEnumerable<float>)null;

            var actual = floats.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedFloats_Should_ThrowForNullSelector()
        {
            var floats = new[]{ 1.0F, 2.0F, 3.0F };

            var actual = floats.Product((Func<float, float>)null);
        }

        [TestMethod]
        public void ProductOfTransformedNullableFloats_Should_ComputeTheProduct()
        {
            var floats = new float?[]{ 1.0F, 2.0F, 3.0F };
            var expected = (float?)(1.0F * 2.0F * 3.0F);

            var actual = floats.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableFloats_Should_IgnoreNullValues()
        {
            var floats = new float?[]{ 1.0F, null, 2.0F, null, 3.0F, null };
            var expected = (float?)(1.0F * 2.0F * 3.0F);

            var actual = floats.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableFloats_Should_ReturnOneForEmptySequence()
        {
            var floats = Enumerable.Empty<float?>();
            var expected = (float?)1.0F;

            var actual = floats.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableFloats_Should_ThrowForNullSequence()
        {
            var floats = (IEnumerable<float?>)null;

            var actual = floats.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableFloats_Should_ThrowForNullSelector()
        {
            var floats = new float?[]{ 1.0F, 2.0F, 3.0F };

            var actual = floats.Product((Func<float?, float?>)null);
        }

        [TestMethod]
        public void ProductOfTransformedDoubles_Should_ComputeTheProduct()
        {
            var doubles = new[]{ 1.0, 2.0, 3.0 };
            var expected = 1.0 * 2.0 * 3.0;

            var actual = doubles.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedDoubles_Should_ReturnOneForEmptySequence()
        {
            var doubles = Enumerable.Empty<double>();
            var expected = 1.0;

            var actual = doubles.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedDoubles_Should_ThrowForNullSequence()
        {
            var doubles = (IEnumerable<double>)null;

            var actual = doubles.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedDoubles_Should_ThrowForNullSelector()
        {
            var doubles = new[]{ 1.0, 2.0, 3.0 };

            var actual = doubles.Product((Func<double, double>)null);
        }

        [TestMethod]
        public void ProductOfTransformedNullableDoubles_Should_ComputeTheProduct()
        {
            var doubles = new double?[]{ 1.0, 2.0, 3.0 };
            var expected = (double?)(1.0 * 2.0 * 3.0);

            var actual = doubles.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableDoubles_Should_IgnoreNullValues()
        {
            var doubles = new double?[]{ 1.0, null, 2.0, null, 3.0, null };
            var expected = (double?)(1.0 * 2.0 * 3.0);

            var actual = doubles.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableDoubles_Should_ReturnOneForEmptySequence()
        {
            var doubles = Enumerable.Empty<double?>();
            var expected = (double?)1.0;

            var actual = doubles.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableDoubles_Should_ThrowForNullSequence()
        {
            var doubles = (IEnumerable<double?>)null;

            var actual = doubles.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableDoubles_Should_ThrowForNullSelector()
        {
            var doubles = new double?[]{ 1.0, 2.0, 3.0 };

            var actual = doubles.Product((Func<double?, double?>)null);
        }

        [TestMethod]
        public void ProductOfTransformedDecimals_Should_ComputeTheProduct()
        {
            var decimals = new[]{ 1.0M, 2.0M, 3.0M };
            var expected = 1.0M * 2.0M * 3.0M;

            var actual = decimals.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedDecimals_Should_ReturnOneForEmptySequence()
        {
            var decimals = Enumerable.Empty<decimal>();
            var expected = 1.0M;

            var actual = decimals.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedDecimals_Should_ThrowForNullSequence()
        {
            var decimals = (IEnumerable<decimal>)null;

            var actual = decimals.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedDecimals_Should_ThrowForNullSelector()
        {
            var decimals = new[]{ 1.0M, 2.0M, 3.0M };

            var actual = decimals.Product((Func<decimal, decimal>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfTransformedDecimals_Should_ThrowOnOverflow()
        {
            var decimals = new[]{ decimal.MaxValue, 10.0M };

            var actual = decimals.Product(x => x);
        }

        [TestMethod]
        public void ProductOfTransformedNullableDecimals_Should_ComputeTheProduct()
        {
            var decimals = new decimal?[]{ 1.0M, 2.0M, 3.0M };
            var expected = (decimal?)(1.0M * 2.0M * 3.0M);

            var actual = decimals.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableDecimals_Should_IgnoreNullValues()
        {
            var decimals = new decimal?[]{ 1.0M, null, 2.0M, null, 3.0M, null };
            var expected = (decimal?)(1.0M * 2.0M * 3.0M);

            var actual = decimals.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductOfTransformedNullableDecimals_Should_ReturnOneForEmptySequence()
        {
            var decimals = Enumerable.Empty<decimal?>();
            var expected = (decimal?)1.0M;

            var actual = decimals.Product(x => x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableDecimals_Should_ThrowForNullSequence()
        {
            var decimals = (IEnumerable<decimal?>)null;

            var actual = decimals.Product(x => x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ProductOfTransformedNullableDecimals_Should_ThrowForNullSelector()
        {
            var decimals = new decimal?[]{ 1.0M, 2.0M, 3.0M };

            var actual = decimals.Product((Func<decimal?, decimal?>)null);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ProductOfTransformedNullableDecimals_Should_ThrowOnOverflow()
        {
            var decimals = new decimal?[]{ decimal.MaxValue, 10.0M };

            var actual = decimals.Product(x => x);
        }
    }
}
