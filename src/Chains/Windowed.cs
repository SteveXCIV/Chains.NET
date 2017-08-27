using System;
using System.Collections.Generic;
using System.Linq;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Produces a sequence of fixed-size windows over the input sequence.
        /// Windows are produced until there are not enough remaining elements
        /// to fill an entire window.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="size">The number of elements in each window.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The size is less than one.
        /// </exception>
        /// <returns>
        /// A sequence of windows over the original sequence.
        /// </returns>
        public static IEnumerable<IEnumerable<TSource>> Windowed<TSource>(
            this IEnumerable<TSource> source,
            int size)
        {
            source.EnsureNotNull(nameof(source));
            size.EnsureGreaterThan(0, nameof(size));

            if (!source.Any()) yield break;

            var seq = source;
            var iter = seq.Skip(size - 1).GetEnumerator();
            while (iter.MoveNext())
            {
                yield return seq.Take(size);
                seq = seq.Skip(1);
            }
            yield break;
        }
    }
}
