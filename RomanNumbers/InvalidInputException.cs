using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbers
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("The input received was invalid.")
        {

        }

    }
}
