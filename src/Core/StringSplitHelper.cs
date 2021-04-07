using System;
using System.Text.RegularExpressions;

namespace CaseConverter.Core
{
    public class StringSplitHelper
    {
        public static String[] SplitByUpperCase(string str)
        {
            string[] parts = Regex.Split(str, @"(?<!^)(?=[A-Z])");
            return parts;
        }
    }
}