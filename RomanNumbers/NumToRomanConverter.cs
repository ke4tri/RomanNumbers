﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumbers
{
    public class NumToRomanConverter
    {
        public string ConvertNumToRoman(int number)
        {

            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");

            if (number >= 1000) return "M" + ConvertNumToRoman(number - 1000);
            if (number >= 900) return "CM" + ConvertNumToRoman(number - 900);
            if (number >= 500) return "D" + ConvertNumToRoman(number - 500);
            if (number >= 400) return "CD" + ConvertNumToRoman(number - 400);
            if (number >= 100) return "C" + ConvertNumToRoman(number - 100);
            if (number >= 90) return "XC" + ConvertNumToRoman(number - 90);
            if (number >= 50) return "L" + ConvertNumToRoman(number - 50);
            if (number >= 10) return "X" + ConvertNumToRoman(number - 10);
            if (number >= 9) return "IX" + ConvertNumToRoman(number - 9);
            if (number >= 5) return "V" + ConvertNumToRoman(number - 5);
            if (number >= 4) return "IV" + ConvertNumToRoman(number - 4);
            if (number >= 1 && number < 4) return "I" + ConvertNumToRoman(number - 1);

            return "";
            
            throw new ArgumentOutOfRangeException("something bad happened");
            //List<string> listOfRoman = new List<string>() {"I", "II" };

            //string[] arrayOfRoman = listOfRoman.ToArray();
            //try
            //{
            //    var indexNumber = Int32.Parse(numToConvert);

            //    var newRomanNumber = arrayOfRoman[indexNumber].ToString();
            //    return newRomanNumber;

            //}
            //catch (FormatException /* ex this would be a var of FormatException*/)
            //{
            //    throw new InvalidInputException();
            //}


        }

        internal object ConvertNumToRoman(string newNumberInput)
        {
            throw new NotImplementedException();
        }
    }
}
