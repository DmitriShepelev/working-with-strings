using System;
using System.Collections.Generic;

#pragma warning disable CA1062
#pragma warning disable SA1615
#pragma warning disable SA1611

namespace WorkingWithStrings
{
    public static class JoiningStrings
    {
        /// <summary>
        /// Concatenates an array of strings, using the comma character between each member.
        /// </summary>
        public static string GetCommaSeparatedString(string[] values)
        {
            return string.Join(',', values);
        }

        /// <summary>
        /// Concatenates an array of strings, using the colon character between each member.
        /// </summary>
        public static string GetColonSeparatedString(string[] values)
        {
            // #6-1. Analyze unit tests for the method, and add the method implementation.
            // Use String.Join method: https://docs.microsoft.com/en-us/dotnet/api/system.string.join
            return string.Join(':', values);
        }

        /// <summary>
        /// Concatenates an array of strings without the first array element, using the comma between each member.
        /// </summary>
        public static string GetCommaSeparatedStringWithoutFirstElement(string[] values)
        {
            // #6-2. Analyze unit tests for the method, and add the method implementation.
            // Use String.Join method: https://docs.microsoft.com/en-us/dotnet/api/system.string.join
            return string.Join(',', values[1..]);
        }

        /// <summary>
        /// Concatenates an array of strings without the first and the last array elements, using the hyphen between each member.
        /// </summary>
        public static string GetHyphenSeparatedStringWithoutFirstAndLastElements(string[] values)
        {
            // #6-3. Analyze unit tests for the method, and add the method implementation.
            // Use String.Join method: https://docs.microsoft.com/en-us/dotnet/api/system.string.join
            return string.Join('-', values[1..^1]);
        }

        /// <summary>
        /// Concatenates an array of strings, using the plus sign between each member.
        /// </summary>
        public static string GetPlusSeparatedString(IEnumerable<string> values)
        {
            // #6-4. Analyze unit tests for the method, and add the method implementation.
            // Use String.Join method: https://docs.microsoft.com/en-us/dotnet/api/system.string.join
            return string.Join('+', values);
        }

        /// <summary>
        /// Concatenates an array of strings, using the backslash sign between each member.
        /// </summary>
        public static string GetBackslashSeparatedString(IEnumerable<object> values)
        {
            // #6-5. Analyze unit tests for the method, and add the method implementation.
            // Use String.Join method: https://docs.microsoft.com/en-us/dotnet/api/system.string.join
            return string.Join('\\', values);
        }

        /// <summary>
        /// Concatenates an array of strings, using the separator string between each member.
        /// </summary>
        public static string GetStringSeparatedString(object[] values)
        {
            // #6-6. Analyze unit tests for the method, and add the method implementation.
            // Use String.Join method: https://docs.microsoft.com/en-us/dotnet/api/system.string.join
            return string.Join("], [", values);
        }

        /// <summary>
        /// Concatenates an array of strings, using the separator string between each member.
        /// </summary>
        public static string GetStringSeparatedStringForLastThreeElements(string separator, string[] values)
        {
            // #6-7. Analyze unit tests for the method, and add the method implementation.
            // Use String.Join method: https://docs.microsoft.com/en-us/dotnet/api/system.string.join
            var sep = separator;
            return string.Join(sep, values[^3..]);
        }
    }
}
