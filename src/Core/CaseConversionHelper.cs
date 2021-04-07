using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CaseConverter.Core
{
    public class CaseConversionHelper
    {
        public static String ConvertPascalCaseToSnakeCase(string str)
        {
            String[] stringParts = StringSplitHelper.SplitByUpperCase(str);
            IEnumerable<string> lowerCaseStringParts = stringParts.Select(p => p.ToLower());
            string snakeCaseStr = string.Join("-", lowerCaseStringParts);
            return snakeCaseStr;
        }
    }
}
