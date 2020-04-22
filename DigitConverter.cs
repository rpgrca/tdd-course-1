namespace RomanNumbers
{
    public class DigitConverter
    {
        private string _one;
        private string _five;
        private string _ten;
        private int _divisor;

        public DigitConverter(string one, string five, string ten, int divisor)
        {
            this._one = one;
            this._five = five;
            this._ten = ten;
            this._divisor = divisor;
        }

        public string ConvertDigit(int numberToConvert)
        {
            numberToConvert = numberToConvert / _divisor % 10;
            string romanNumberAsString = "";

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

                    for (int x = 0; x < numberToConvert % 5; x++)
                    {
                        romanNumberAsString += _one;
                    }
                }
            }

            return romanNumberAsString;
        }
    }
}