using System.Collections.Generic;

namespace RomanNumbers.Logic
{
    public class RomanNumberTextRepresentation
    {
        private readonly List<DigitConverter> _converters = new List<DigitConverter>();

        public RomanNumberTextRepresentation()
        {
            _converters.Add(new DigitConverter("C", "D", "M", 100));
            _converters.Add(new DigitConverter("X", "L", "C", 10));
            _converters.Add(new DigitConverter("I", "V", "X", 1));
        }

        public string ConvertToRoman(int numberToConvert)
        {
            var romanNumberAsString = "";

            foreach (DigitConverter digitConverter in _converters)
            {
                romanNumberAsString += digitConverter.ConvertDigit(numberToConvert);
            }

            return romanNumberAsString;
        }
    }
}