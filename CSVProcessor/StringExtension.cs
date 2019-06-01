using System;

namespace CSVProcessor
{
    public static class StringExtension
    {
        public static bool Contains(this string originalStr, string value, StringComparison comparison)
        {
            return originalStr.IndexOf(value, comparison) > 0;
        }
    }
}