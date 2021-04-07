using System;
using Xunit;

namespace CaseConverter.Core.Tests
{
    public class StringSplitHelperTest
    {
        [Theory]
        [InlineData("NewClass", new [] {"New", "Class"})]
        [InlineData("Newclass", new[] { "Newclass" })]
        [InlineData("NewClassTest", new[] { "New", "Class", "Test" })]
        [InlineData("NewclassTest", new[] { "Newclass", "Test" })]
        [InlineData("ThisIsTheStringToSplit", new[] { "This", "Is", "The", "String", "To", "Split" })]
        [InlineData("ABC", new[] { "A", "B", "C" })]
        public void SplitByUpperCaseTheory(string str, String[] expectedResult)
        {
            String[] result = StringSplitHelper.SplitByUpperCase(str);

            Assert.Equal(expectedResult.Length, result.Length);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                string expectedResultItem = expectedResult[i];
                string resultItem = result[i];

                Assert.Equal(expectedResultItem,resultItem);
            }
        }
    }
}
