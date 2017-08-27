using System;
using System.Collections.Generic;
using System.Linq;

namespace Chains
{
    public static partial class Chains
    {
        /// <summary>
        /// Applies an accumulator function over a sequence of values, yielding
        /// a state value each iteration. The seed is used as the initial
        /// accumulator value, and each intermediate state is transformed using
        /// a transformation function.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <typeparam name="TState">
        /// The type of the intermediate state.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the transformed state.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="accumulator">The accumulator function.</param>
        /// <param name="transformer">The transformation function.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The accumulator function is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The transformation function is null.
        /// </exception>
        /// <returns>
        /// The sequence of transformed intermediate states of the accumulator.
        /// </returns>
        public static IEnumerable<TResult> Scan<TSource, TState, TResult>(
            this IEnumerable<TSource> source,
            TState seed,
            Func<TState, TSource, TState> accumulator,
            Func<TState, TResult> transformer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Applies an accumulator function over a sequence of values, yielding
        /// a state value each iteration. The seed is used as the initial
        /// accumulator value.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <typeparam name="TState">
        /// The type of the intermediate state.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="accumulator">The accumulator function.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The accumulator function is null.
        /// </exception>
        /// <returns>
        /// The sequence of intermediate states of the accumulator.
        /// </returns>
        public static IEnumerable<TState> Scan<TSource, TState>(
            this IEnumerable<TSource> source,
            TState seed,
            Func<TState, TSource, TState> accumulator)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Applies an accumulator function over a sequence of values, yielding
        /// a state value each iteration. The initial accumulator value is the
        /// first value in the sequence.
        /// </summary>
        /// <typeparam name="TSource">
        /// The type of the items in the source enumerable.
        /// </typeparam>
        /// <param name="source">The source enumerable to operate on.</param>
        /// <param name="accumulator">The accumulator function.</param>
        /// <exception cref="ArgumentNullException">
        /// The source is null.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The accumulator function is null.
        /// </exception>
        /// <returns>
        /// The sequence of intermediate states of the accumulator.
        /// </returns>
        public static IEnumerable<TSource> Scan<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, TSource, TSource> accumulator)
        {
            throw new NotImplementedException();
        }
    }
}
