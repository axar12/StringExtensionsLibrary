using System;

namespace StringExtensionsLibrary
{
    public static class StringHelper
    {
        /// <summary>
        /// Checks if the string starts with an uppercase letter.
        /// </summary>
        /// <param name="str">The input string to check.</param>
        /// <returns>True if the string starts with an uppercase letter; otherwise, false.</returns>
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char firstChar = str[0];
            return char.IsUpper(firstChar);
        }
    }
}
