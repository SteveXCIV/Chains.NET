using System;
using System.Collections.Generic;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Performs a given action on each element in an
        /// <see cref="IEnumerable{T}" />.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="action">The action to perform on each element.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The action is null.
        /// </exception>
        public static void ForEach<TSource>(
            this IEnumerable<TSource> source,
            Action<TSource> action)
        {
            source.EnsureNotNull(nameof(source));
            action.EnsureNotNull(nameof(action));

            foreach (var element in source) action(element);
        }
    }
}
