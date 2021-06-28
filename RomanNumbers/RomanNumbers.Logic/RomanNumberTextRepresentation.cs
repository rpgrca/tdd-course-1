using System.Collections.Generic;

namespace RomanNumbers.Logic
{
    public class RomanNumberTextRepresentation
    {
        private readonly List<DigitConverter> _converters = new();

        public RomanNumberTextRepresentation()
        {
            _converters.Add(new("C", "D", "M", 100));
            _converters.Add(new("X", "L", "C", 10));
            _converters.Add(new("I", "V", "X", 1));
        }

        public string ConvertToRoman(int numberToConvert)
        {
            var romanNumberAsString = "";

            foreach (var digitConverter in _converters)
            {
                romanNumberAsString += digitConverter.ConvertDigit(numberToConvert);
            }

            return romanNumberAsString;
        }
    }
}