using System;
using System.Collections.Generic;
using System.Linq;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Splits elements of an <see cref="IEnumerable{TSource}"/> into chunks
        /// with a given maximum size.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerables.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="size">The maximum chunk size.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The size is not a positive integer.
        /// </exception>
        /// <returns>
        /// An enumerable of enumerables, where each one contains at most `size`
        /// number of elements.
        /// </returns>
        public static IEnumerable<IEnumerable<TSource>> ChunkBy<TSource>(
            this IEnumerable<TSource> source,
            int size)
        {
            source.EnsureNotNull(nameof(source));
            size.Ensure(x => x > 0, nameof(size), "Must be a positive integer.");

            if (!source.Any())
            {
                yield return Enumerable.Empty<TSource>();
                yield break;
            }

            var chunk = source.Take(size);
            var rest = source.Skip(size);

            while (chunk.Any())
            {
                yield return chunk;
                chunk = rest.Take(size);
                rest = rest.Skip(size);
            }
        }
    }
}
