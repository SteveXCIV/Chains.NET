using System;

namespace Chains
{
    internal static class RequirementHelper
    {
        private const string ArgumentTooSmallMessage = "Given argument was less than the specified minimum of {0}.";
        private const string ArgumentTooLargeMessage = "Given argument was greater than the specified maximum of {0}.";

        internal static TSource EnsureNotNull<TSource>(this TSource source, string name)
        {
            if (source == null)
                throw new ArgumentNullException(name);
            return source;
        }

        internal static TSource EnsureBetweenInclusive<TSource, TCompare>(this TSource source, TCompare min, TCompare max, string name)
            where TSource : IComparable<TCompare>
        {
            if (source.CompareTo(min) < 0)
                throw new ArgumentOutOfRangeException(name, source, string.Format(ArgumentTooSmallMessage, min));
            else if (source.CompareTo(max) > 0)
                throw new ArgumentOutOfRangeException(name, source, string.Format(ArgumentTooLargeMessage, max));
            return source;
        }

        internal static TSource EnsureGreaterThan<TSource, TCompare>(this TSource source, TCompare other, string name)
            where TSource : IComparable<TCompare>
        {
            if (source.CompareTo(other) <= 0)
                throw new ArgumentOutOfRangeException(name, source, string.Format(ArgumentTooSmallMessage, other));
            return source;
        }

        internal static TSource EnsureLessThan<TSource, TCompare>(this TSource source, TCompare other, string name)
            where TSource : IComparable<TCompare>
        {
            if (source.CompareTo(other) >= 0)
                throw new ArgumentOutOfRangeException(name, source, string.Format(ArgumentTooLargeMessage, other));
            return source;
        }

        internal static TSource Ensure<TSource>(this TSource source, Func<TSource, bool> requirement, string name, string message)
        {
            if (!requirement(source))
                throw new ArgumentException(name, message);
            return source;
        }
    }
}
