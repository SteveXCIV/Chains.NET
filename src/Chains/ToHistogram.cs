using System;
using System.Collections.Generic;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Creates a histogram of a given <see cref="IEnumerable{T}" />.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <returns>
        /// An <see cref="IDictionary{TKey,TValue}" /> mapping each element in
        /// the source enumerable to the number of times it appeared.
        /// </returns>
        public static IDictionary<TSource, int> ToHistogram<TSource>(
            this IEnumerable<TSource> source)
        {
            throw new NotImplementedException();
        }
    }
}
