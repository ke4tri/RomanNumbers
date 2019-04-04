using System;
using Xunit;

namespace RomanNumbers.Test
{
    public class creating_roman_number_from_number_input
    {
        [Fact]
        public void Test_number_1_to_roman()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            int input = 1;
            var expectedResult = "I";

            //Act     -- Do the thing         -- When
            string actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);
           
        }

        [Fact]
        public void Test_number_4_to_roman()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            int input = 4;
            var expectedResult = "IV";

            //Act     -- Do the thing         -- When
            string actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Test_number_5_to_roman()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            int input = 5;
            var expectedResult = "V";

            //Act     -- Do the thing         -- When
            string actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Test_number_10_to_roman()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            int input = 10;
            var expectedResult = "X";

            //Act     -- Do the thing         -- When
            string actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Test_number_9_to_roman()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            int input = 9;
            var expectedResult = "IX";

            //Act     -- Do the thing         -- When
            string actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Test_number_50_to_roman()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            int input = 50;
            var expectedResult = "L";

            //Act     -- Do the thing         -- When
            string actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Test_number_39_to_roman()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            int input = 39;
            var expectedResult = "XXXIX";

            //Act     -- Do the thing         -- When
            string actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Test_number_Large_to_roman()
        {
            //Arrange -- Context              -- Given
            var convert = new NumToRomanConverter();
            int input = 3999;
            var expectedResult = "MMMCMXCIX";

            //Act     -- Do the thing         -- When
            string actualResult = convert.ConvertNumToRoman(input);

            //Assert  -- checking the result  -- Then
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
