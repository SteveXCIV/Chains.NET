using System;
using System.Collections.Generic;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Yields the distinct values in an <see cref="IEnumerable{TSource}"/>
        /// according to a key-selection function.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <typeparam name="TKey">
        /// The type of the key.
        /// This type must implement <see cref="IEquatable{T}" />.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="selector">The key-selection function to use.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The selector is null.
        /// </exception>
        /// <returns>
        /// A sequence of values distinct by the key-selection function.
        /// </returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> selector)
            where TKey : IEquatable<TKey>
        {
            source.EnsureNotNull(nameof(source));
            selector.EnsureNotNull(nameof(selector));

            var hashSet = new HashSet<TKey>();

            foreach (var item in source)
                if (hashSet.Add(selector(item))) yield return item;
        }
    }
}
