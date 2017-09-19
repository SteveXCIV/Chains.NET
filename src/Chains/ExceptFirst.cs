using System;
using System.Linq;
using System.Collections.Generic;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Yields the values in an <see cref="IEnumerable{TSource}"/>
        /// except the first element.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// The source is empty.
        /// </exception>
        /// <returns>
        /// An enumerable containing all except the first element in the source.
        /// </returns>
        public static IEnumerable<TSource> ExceptFirst<TSource>(
            this IEnumerable<TSource> source)
        {
            throw new NotImplementedException();
        }
    }
}
