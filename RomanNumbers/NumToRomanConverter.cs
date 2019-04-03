using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumbers
{
    public class NumToRomanConverter
    {
        public string ConvertNumToRoman(string numToConvert)
        {
            try
            {
                var newNumber = numToConvert;
                var convertedNumber = "I";

                return convertedNumber;
            }
            catch (FormatException /* ex this would be a var of FormatException*/)
            {
                throw new InvalidInputException();
            }


        }
    }
}
