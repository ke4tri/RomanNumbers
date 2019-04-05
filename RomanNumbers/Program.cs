using System;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The 'Roman Number Translator System' ");
            Console.WriteLine("You can start by entering any number you wish.");
            Console.WriteLine("But... Lets start with a number 1 - 5 : ");


            string numberInput = Console.ReadLine();
            int numberInputInt = int.Parse(numberInput);
            var convert = new NumToRomanConverter();
            var romanNumber = convert.ConvertNumToRoman(numberInputInt);
            var romanNumber2 = convert.ConvertNumToRoman2(numberInputInt);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Using ConvertNumberToRoman()");
            Console.WriteLine($"The Convertion of your selection : {numberInputInt} is ---> {romanNumber}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Using ConvertNumberToRoman2()");
            Console.WriteLine($"The Convertion of your selection : {numberInputInt} is ---> {romanNumber2}");



            Console.ReadLine();

            // var newNumberInput = numberInput.ToString();

            //var convertedInput = new NumToRomanConverter();
            //var converMethod = convertedInput.ConvertNumToRoman(numberInput);
            //Console.WriteLine($"Your Roman number is {converMethod}");
            //Console.ReadLine();
        }
    }
}
