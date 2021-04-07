using System;
using Xunit;

namespace CaseConverter.Core.Tests
{
    public class CaseConversionHelperTest
    {
        [Theory]
        [InlineData("NewClass", "new-class")]
        [InlineData("ThisIsTheStringToSplit", "this-is-the-string-to-split")]
        [InlineData("ABC", "a-b-c")]
        public void ConvertPascalCaseToSnakeCaseTheory(string str, String expectedResult)
        {
            String result = CaseConversionHelper.ConvertPascalCaseToSnakeCase(str);
            Assert.Equal(expectedResult, result);
        }
    }
}
