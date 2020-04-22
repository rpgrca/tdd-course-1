namespace RomanNumbers
{
    public class DigitConverter
    {
        public string ConvertDigit(int numberToConvert, string romanNumberAsString, string one, string five, string ten)
        {
            if (numberToConvert == 4)
            {
                romanNumberAsString += one + five;
            }
            else
            {
                if (numberToConvert == 9)
                {
                    romanNumberAsString += one + ten;
                }
                else
                {
                    if (numberToConvert >= 5 && numberToConvert <= 8)
                    {
                        romanNumberAsString += five;
                    }

                    for (int x = 0; x < numberToConvert % 5; x++)
                    {
                        romanNumberAsString += one;
                    }
                }
            }

            return romanNumberAsString;
        }
    }
}