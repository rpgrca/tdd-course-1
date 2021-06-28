namespace RomanNumbers.Logic
{
    public class DigitConverter
    {
        private readonly string _one;
        private readonly string _five;
        private readonly string _ten;
        private readonly int _divisor;

        public DigitConverter(string one, string five, string ten, int divisor) =>
            (_one, _five, _ten, _divisor) = (one, five, ten, divisor);

        public string ConvertDigit(int numberToConvert)
        {
            numberToConvert = numberToConvert / _divisor % 10;
            var romanNumberAsString = "";

            if (numberToConvert == 4)
            {
                romanNumberAsString += _one + _five;
            }
            else
            {
                if (numberToConvert == 9)
                {
                    romanNumberAsString += _one + _ten;
                }
                else
                {
                    if (numberToConvert >= 5 && numberToConvert <= 8)
                    {
                        romanNumberAsString += _five;
                    }

                    for (var x = 0; x < numberToConvert % 5; x++)
                    {
                        romanNumberAsString += _one;
                    }
                }
            }

            return romanNumberAsString;
        }
    }
}