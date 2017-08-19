using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloDev.StringExtensions
{
    public static class TrimExtensions
    {
        public static string FirstWord(this string str)
        {
            return str.First(' ');
        }
        public static string LastWord(this string str)
        {
            return str.Last(' ');
        }

        public static string First(this string str, params char[] split)
        {
            return str.Split(split).FirstOrDefault();
        }

        public static string First(this string str, params string[] split)
        {
            return str.Split(split, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
        }

        public static string Last(this string str, params char[] split)
        {
            return str.Split(split).LastOrDefault();
        }

        public static string Last(this string str, params string[] split)
        {
            return str.Split(split, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
        }

        public static IEnumerable<string> Range(this string str, int start, int end, params char[] split)
        {
            return str.Split(split).Skip(start).Take(end - start + 1);
        }

        public static IEnumerable<string> Range(this string str, int start, int end, params string[] split)
        {
            return str.Split(split, StringSplitOptions.RemoveEmptyEntries).Skip(start).Take(end - start);
        }
    }
}
