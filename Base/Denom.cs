using System;
using System.Text.RegularExpressions;

namespace Cosmcs.Base
{
    public class Denom
    {
        public string D { get; }

        public Denom(string s)
        {
            if (!Regex.IsMatch(s, @"^[[A-Z]|[a-z]|[0-9]|\/]*"))
            {
                throw new Exception("invalid denom");
            }

            D = s;
        }
    }
}