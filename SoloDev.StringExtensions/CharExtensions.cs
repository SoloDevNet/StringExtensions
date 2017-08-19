using System;
using System.Collections.Generic;
using System.Text;

namespace SoloDev.StringExtensions
{
    public static class CharExtensions
    {
        public static char ToUpper(this char ch)
        {
            return char.ToUpper(ch);
        }
        public static char ToUpperInvariant(this char ch)
        {
            return char.ToUpperInvariant(ch);
        }

        public static char ToLower(this char ch)
        {
            return char.ToLower(ch);
        }

        public static char ToLowerInvariant(this char ch)
        {
            return char.ToLowerInvariant(ch);
        }

        public static bool IsLetter(this char ch)
        {
            return char.IsLetter(ch);
        }

        public static bool IsDigit(this char ch)
        {
            return char.IsDigit(ch);
        }

        public static bool IsLetterOrDigit(this char ch)
        {
            return char.IsLetterOrDigit(ch);
        }

        public static bool IsWhiteSpace(this char ch)
        {
            return char.IsWhiteSpace(ch);
        }

        public static bool IsPunctuation(this char ch)
        {
            return char.IsPunctuation(ch);
        }

        public static bool IsSymbol(this char ch)
        {
            return char.IsSymbol(ch);
        }

        public static bool IsLower(this char ch)
        {
            return char.IsLower(ch);
        }

        public static bool IsUpper(this char ch)
        {
            return char.IsUpper(ch);
        }
    }
}
