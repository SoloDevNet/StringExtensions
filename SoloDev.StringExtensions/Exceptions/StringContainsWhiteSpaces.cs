using System;
using System.Collections.Generic;
using System.Text;

namespace SoloDev.StringExtensions.Exceptions
{
    public class StringContainsWhiteSpaces : Exception
    {
        public StringContainsWhiteSpaces(string message = "String cannot contain white spaces") : base(message)
        {
        }
    }
}
