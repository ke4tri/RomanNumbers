using System;
using Xunit;

namespace RomanNumbers.Test
{
    public class creating_roman_number_from_number_input
    {
        [Fact]
        public void Test1()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            var input = "1";
            var expectedResult = "I";

            //Act     -- Do the thing         -- When
            var actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
