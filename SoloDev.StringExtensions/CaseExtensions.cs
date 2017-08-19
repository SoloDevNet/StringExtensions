using SoloDev.StringExtensions.Exceptions;
using System;
using System.Linq;
using System.Text;

namespace SoloDev.StringExtensions
{
    public static class CaseExtensions
    {
        public static string ToPascalCase(this string str)
        {
            return str.DetectAndNormalize();
        }

        public static string ToCamelCase(this string str)
        {
            return str.DetectAndNormalize().FirstLetterLower();
        }

        public static string ToKebabCase(this string str)
        {
            return string.Join("", str
                .DetectAndNormalize()
                .Select(x => x.IsUpper() ? $"-{x.ToLower()}" : x.ToString()))
                .Trim('-');
        }

        public static string ToHungarianNotation(this string str)
        {
            return string.Join("", str
                .DetectAndNormalize()
                .Select(x => x.IsUpper() ? $"_{x.ToLower()}" : x.ToString()))
                .Trim('_');
        }

        public static string Slugify(this string str)
        {
            return string.Join("", str.ToKebabCase()
                .Where(x => x.IsLetterOrDigit() || x == '-'));
        }

        public static bool IsCamelCase(this string str)
        {
            if (str.PassesSanityCheckForCases())
            {
                return str.All(x=> x.IsLetter()) && str.FirstOrDefault().IsLower();
            }

            return false;
        }

        public static bool IsPascalCase(this string str)
        {
            if (str.PassesSanityCheckForCases())
            {
                return str.All(x => x.IsLetter()) && str.FirstOrDefault().IsUpper();
            }

            return false;
        }

        public static bool IsKebabCase(this string str)
        {
            if (str.PassesSanityCheckForCases())
            {
                return str.All(x => x.IsLetter() || x == '-') && !str.ContainsUpper();
            }

            return false;
        }

        public static bool IsHungarianNotation(this string str)
        {
            if (str.PassesSanityCheckForCases())
            {
                return str.All(x => x.IsLetter() || x == '_') && !str.ContainsUpper();
            }

            return false;
        }

        private static bool PassesSanityCheckForCases(this string str)
        {
            return !str.Contains(" ");
        }

        /// <summary>
        /// Already detected
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string FromHungarianNotation(this string str)
        {
            return str.Replace('_', ' ').EveryWordUpper().Replace(" ", "");
        }

        /// <summary>
        /// Already detected
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string FromCamelCase(this string str)
        {
            return $"{str.FirstOrDefault().ToUpper()}{str.Substring(1)}";
        }

        /// <summary>
        /// Already detected
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string FromKebabCase(this string str)
        {
            return str.Replace('-', ' ').EveryWordUpper().Replace(" ", "");
        }

        private static string DetectAndNormalize(this string str)
        {
            if (str.IsHungarianNotation())
            {
                return str.FromHungarianNotation();
            }

            if (str.IsCamelCase())
            {
                return str.FromCamelCase();
            }

            if (str.IsKebabCase())
            {
                return str.FromKebabCase();
            }

            return str.EveryLetterUpper().Replace(" ", "");
        }
    }
}
