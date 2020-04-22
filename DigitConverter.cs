namespace RomanNumbers
{
    public class DigitConverter
    {
        private string _one;
        private string _five;
        private string _ten;

        public DigitConverter(string one, string five, string ten)
        {
            this._one = one;
            this._five = five;
            this._ten = ten;
        }

        public string ConvertDigit(int numberToConvert, string romanNumberAsString)
        {
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