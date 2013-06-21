using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auxilium_Server
{
    internal static class ExtensionMethods
    {
        public static bool IsNullOrWhiteSpace(this string input)
        {
            return string.IsNullOrEmpty(input.Trim());
        }
    }
}
