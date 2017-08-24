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

            throw new NotImplementedException();
        }
    }
}
