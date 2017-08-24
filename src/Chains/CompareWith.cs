using System;
using System.Collections.Generic;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Compares the values in two <see cref="IEnumerable{TSource}"/>
        /// instances, element-by-element.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerables.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="other">The enumerable to compare to.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The other is null.
        /// </exception>
        /// <returns>
        /// The first non-zero value of element-by-element comparison, or the
        /// value -1 if the first sequence is shorter, the value +1 if the
        /// second sequence is shorter, or finally the value 0.
        /// </returns>
        public static int CompareWith<TSource>(
            this IEnumerable<TSource> source,
            IEnumerable<TSource> other)
            where TSource : IComparable<TSource>
        {
            source.EnsureNotNull(nameof(source));
            other.EnsureNotNull(nameof(other));

            var leftEnumerator = source.GetEnumerator();
            var rightEnumerator = other.GetEnumerator();
            var leftMoved = false;
            var rightMoved = false;

            while (true)
            {
                leftMoved = leftEnumerator.MoveNext();
                rightMoved = rightEnumerator.MoveNext();

                if (!leftMoved && !rightMoved) return 0;
                else if (!leftMoved && rightMoved) return -1;
                else if (leftMoved && !rightMoved) return 1;

                var comparison = leftEnumerator.Current
                    .CompareTo(rightEnumerator.Current);

                if (comparison != 0) return comparison;
            }
        }

        /// <summary>
        /// Compares the values in two <see cref="IEnumerable{TSource}"/>
        /// instances, element-by-element, using a key-selection function.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerables.
        /// </typeparam>
        /// <typeparam name="TKey">
        /// The type of the key.
        /// This type must implement <see cref="IComparable{T}" />.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="other">The enumerable to compare to.</param>
        /// <param name="selector">The key-selection function.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The other is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The key-selection function is null.
        /// </exception>
        /// <returns>
        /// The first non-zero value of element-by-element comparison after
        /// applying the key-selection function, or the value -1 if the first
        /// sequence is shorter, the value +1 if the second sequence is shorter,
        /// or finally the value 0.
        /// </returns>
        public static int CompareWith<TSource, TKey>(
            this IEnumerable<TSource> source,
            IEnumerable<TSource> other,
            Func<TSource, TKey> selector)
            where TKey : IComparable<TKey>
        {
            selector.EnsureNotNull(nameof(selector));

            throw new NotImplementedException();
        }
    }
}
