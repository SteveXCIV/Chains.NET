using System;
using System.Collections.Generic;
using System.Linq;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Computes the product of a sequence of <see cref="Int32" /> values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static int Product(this IEnumerable<int> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .Aggregate(1, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of nullable
        /// <see cref="Int32" /> values, excluding null values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static int? Product(this IEnumerable<int?> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .OfType<int>()
                .Aggregate(1, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Int64" /> values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static long Product(this IEnumerable<long> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .Aggregate(1L, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of nullable
        /// <see cref="Int64" /> values, excluding null values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static long? Product(this IEnumerable<long?> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .OfType<long>()
                .Aggregate(1L, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Single" /> values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static float Product(this IEnumerable<float> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .Aggregate(1.0F, (x, y) => x * y);
        }

        /// <summary>
        /// Computes the product of a sequence of nullable
        /// <see cref="Single" /> values, excluding null values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static float? Product(this IEnumerable<float?> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .OfType<float>()
                .Aggregate(1.0F, (x, y) => x * y);
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Double" /> values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static double Product(this IEnumerable<double> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .Aggregate(1.0, (x, y) => x * y);
        }

        /// <summary>
        /// Computes the product of a sequence of nullable
        /// <see cref="Double" /> values, excluding null values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static double? Product(this IEnumerable<double?> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .OfType<double>()
                .Aggregate(1.0, (x, y) => x * y);
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Decimal" /> values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static decimal Product(this IEnumerable<decimal> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .Aggregate(1.0M, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of nullable
        /// <see cref="Decimal" /> values, excluding null values.
        /// </summary>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the values, or one if the sequence is empty.
        /// </returns>
        public static decimal? Product(this IEnumerable<decimal?> source)
        {
            source.EnsureNotNull(nameof(source));

            return source
                .OfType<decimal>()
                .Aggregate(1.0M, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Int32" /> values,
        /// obtained by invoking a transform function on the elements of the
        /// input sequence.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <exceptuon cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static int Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, int> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .Aggregate(1, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of nullable <see cref="Int32" />
        /// values, obtained by invoking a transform function on the elements
        /// of the input sequence, excluding null values.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <exceptuon cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static int? Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, int?> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .OfType<int>()
                .Aggregate(1, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Int64" /> values,
        /// obtained by invoking a transform function on the elements of the
        /// input sequence.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <exceptuon cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static long Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, long> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .Aggregate(1L, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of nullable <see cref="Int64" />
        /// values, obtained by invoking a transform function on the elements
        /// of the input sequence, excluding null values.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <exceptuon cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static long? Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, long?> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .OfType<long>()
                .Aggregate(1L, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Single" /> values,
        /// obtained by invoking a transform function on the elements of the
        /// input sequence.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static float Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, float> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .Aggregate(1.0F, (x, y) => x * y);
        }

        /// <summary>
        /// Computes the product of a sequence of nullable <see cref="Single" />
        /// values, obtained by invoking a transform function on the elements
        /// of the input sequence, excluding null values.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static float? Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, float?> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .OfType<float>()
                .Aggregate(1.0F, (x, y) => x * y);
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Double" /> values,
        /// obtained by invoking a transform function on the elements of the
        /// input sequence.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static double Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, double> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .Aggregate(1.0, (x, y) => x * y);
        }

        /// <summary>
        /// Computes the product of a sequence of nullable <see cref="Double" />
        /// values, obtained by invoking a transform function on the elements
        /// of the input sequence, excluding null values.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static double? Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, double?> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .OfType<double>()
                .Aggregate(1.0, (x, y) => x * y);
        }

        /// <summary>
        /// Computes the product of a sequence of <see cref="Decimal" /> values,
        /// obtained by invoking a transform function on the elements of the
        /// input sequence.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <exceptuon cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static decimal Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, decimal> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .Aggregate(1.0M, (x, y) => { checked { return x * y; } });
        }

        /// <summary>
        /// Computes the product of a sequence of nullable
        /// <see cref="Decimal" /> values, obtained by invoking a transform
        /// function on the elements of the input sequence, excluding null
        /// values.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The transformation function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <exceptuon cref="OverflowException">
        /// The product exceeds the maximum value.
        /// </exception>
        /// <returns>
        /// The product of the projected values, or one if the sequence is
        /// empty.
        /// </returns>
        public static decimal? Product<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, decimal?> selector)
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            return source
                .Select(selector)
                .OfType<decimal>()
                .Aggregate(1.0M, (x, y) => { checked { return x * y; } });
        }
    }
}
