using System;
using System.Linq;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace RomanNumbers
{
    public class RomanNumberTest
    {
        [Fact] public void testA() => convertToRoman(1).Should().Be("I");
        [Fact] public void testB() => convertToRoman(2).Should().Be("II");
        [Fact] public void testC() => convertToRoman(3).Should().Be("III");
        [Fact] public void testD() => convertToRoman(4).Should().Be("IV");
        [Fact] public void testE() => convertToRoman(5).Should().Be("V");
        [Fact] public void testF() => convertToRoman(6).Should().Be("VI");
        [Fact] public void testG() => convertToRoman(7).Should().Be("VII");
        [Fact] public void testH() => convertToRoman(8).Should().Be("VIII");
        [Fact] public void testI() => convertToRoman(9).Should().Be("IX");
        [Fact] public void testJ()
        {
            convertToRoman(10).Should().Be("X");
            convertToRoman(11).Should().Be("XI");
            convertToRoman(12).Should().Be("XII");
            convertToRoman(13).Should().Be("XIII");
        }
        [Fact] public void testK() => convertToRoman(14).Should().Be("XIV");
        [Fact] public void testL() => convertToRoman(15).Should().Be("XV");
        [Fact] public void testM()
        {
            convertToRoman(16).Should().Be("XVI");
            convertToRoman(17).Should().Be("XVII");
            convertToRoman(18).Should().Be("XVIII");
        }

        private string convertToRoman(int numberToConvert)
        {
            string romanNumberAsString = "";

            if (numberToConvert == 4)
            {
                romanNumberAsString = "IV";
            }
            else
            {
                if (numberToConvert == 9)
                {
                    romanNumberAsString = "IX";
                }
                else
                {
                    if (numberToConvert == 14)
                    {
                        romanNumberAsString = "XIV";
                    }
                    else if (numberToConvert == 15)
                    {
                        romanNumberAsString = "XV";
                    }
                    else if (numberToConvert >= 16 && numberToConvert <= 18)
                    {
                        romanNumberAsString = "XV";
                        romanNumberAsString = addITo(numberToConvert, romanNumberAsString);
                    }
                    else if (numberToConvert >= 10 && numberToConvert <= 13)
                    {
                        romanNumberAsString = "X";
                        romanNumberAsString = addITo(numberToConvert, romanNumberAsString);
                    }
                    else
                    {
                        if (numberToConvert >= 5 && numberToConvert <= 8)
                        {
                            romanNumberAsString = "V";
                        }

                        romanNumberAsString = addITo(numberToConvert, romanNumberAsString);
                    }
                }
            }

            return romanNumberAsString;
        }

        private string addITo(int numberToConvert, string romanNumberAsString)
        {
            for (int x = 0; x < numberToConvert % 5; x++)
            {
                romanNumberAsString += "I";
            }

            return romanNumberAsString;
        }
    }
}