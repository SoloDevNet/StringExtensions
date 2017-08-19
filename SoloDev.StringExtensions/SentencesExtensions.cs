using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloDev.StringExtensions
{
    public static class SentencesExtensions
    {
        /// <summary>
        /// Change the first letter of the first word to upper case
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FirstLetterUpper(this string str)
        {
            return str.FirstOrDefault().ToUpper() + str.Substring(1);
        }

        /// <summary>
        /// Change the first letter of the first word to upper case, lowercase everything else
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FirstWordUpper(this string str)
        {
            return str.FirstOrDefault().ToUpper() + str.Substring(1).ToLower();
        }

        /// <summary>
        /// Change the first letter of the first word to upper case, lowercase everything else
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FirstLetterLower(this string str)
        {
            return str.FirstOrDefault().ToLower() + str.Substring(1);
        }

        /// <summary>
        /// Change the first letter of every word to upper case
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EveryLetterUpper(this string str)
        {
            return string.Join(" ", str.Split(' ').Select(x => x.FirstLetterUpper()));
        }

        /// <summary>
        /// Change the first letter of every word to upper case
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EveryLetterLower(this string str)
        {
            return string.Join(" ", str.Split(' ').Select(x => x.FirstLetterLower()));
        }

        /// <summary>
        /// Change the first letter of every word to upper case, lowercase everything else
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EveryWordUpper(this string str)
        {
            return string.Join(" ", str.Split(' ').Select(x => x.FirstWordUpper()));
        }

        public static bool ContainsUpper(this string str)
        {
            return str.Any(x => x >= 'A' && x <= 'Z');
        }

        public static bool ContainsLower(this string str)
        {
            return str.Any(x => x >= 'a' && x <= 'z');
        }

        public static bool ContainsDigits(this string str)
        {
            return str.Any(x => x >= '0' && x <= '9');
        }
    }
}
