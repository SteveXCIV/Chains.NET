using System;
using System.Collections.Generic;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Yields the values in an <see cref="IEnumerable{TSource}"/>
        /// infinitely, starting over again if the end is reached.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <returns>
        /// An infinitely repeating version of the source enumerable.
        /// </returns>
        public static IEnumerable<TSource> Cycle<TSource>(
            this IEnumerable<TSource> source)
        {
            source.EnsureNotNull(nameof(source));

            throw new NotImplementedException();
        }
    }
}
