using System;

namespace Chains
{
    public static class Helpers
    {
        private const string ArgumentTooSmallMessage = "Given argument was less than the specified minimum of {0}.";
        private const string ArgumentTooLargeMessage = "Given argument was greater than the specified maximum of {0}.";

        public static TSource EnsureNotNull<TSource>(this TSource source, string name) where TSource: class
        {
            if (source == null)
                throw new ArgumentNullException(name);
            return source;
        }

        public static TSource EnsureBetweenInclusive<TSource, TCompare>(this TSource source, TCompare min, TCompare max, string name)
            where TSource : IComparable<TCompare>
        {
            if (source.CompareTo(min) < 0)
                throw new ArgumentOutOfRangeException(name, source, string.Format(ArgumentTooSmallMessage, min));
            else if (source.CompareTo(max) > 0)
                throw new ArgumentOutOfRangeException(name, source, string.Format(ArgumentTooLargeMessage, max));
            return source;
        }
    }
}
