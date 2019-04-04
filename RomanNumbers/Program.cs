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


            var numberInput = Console.ReadLine();
            var newNumberInput = numberInput.ToString();

            var convertedInput = new NumToRomanConverter();
            var converMethod = convertedInput.ConvertNumToRoman(newNumberInput);
            Console.WriteLine($"Your Roman number is {converMethod}");
            Console.ReadLine();

        }
    }
}
