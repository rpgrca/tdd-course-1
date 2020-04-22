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
        [Fact] public void testE()
        {
            convertToRoman(5).Should().Be("V");
            convertToRoman(6).Should().Be("VI");
            convertToRoman(7).Should().Be("VII");
            convertToRoman(8).Should().Be("VIII");
        } 
        [Fact] public void testF() => convertToRoman(9).Should().Be("IX");
        [Fact] public void testG()
        {
            convertToRoman(10).Should().Be("X");
            convertToRoman(11).Should().Be("XI");
            convertToRoman(12).Should().Be("XII");
            convertToRoman(13).Should().Be("XIII");
        }
        [Fact] public void testH() => convertToRoman(14).Should().Be("XIV");
        [Fact] public void testI() => convertToRoman(15).Should().Be("XV");
        [Fact] public void testM()
        {
            convertToRoman(16).Should().Be("XVI");
            convertToRoman(17).Should().Be("XVII");
            convertToRoman(18).Should().Be("XVIII");
        }
        [Fact] public void testN() => convertToRoman(19).Should().Be("XIX");
        [Fact] public void testO()
        {
            convertToRoman(20).Should().Be("XX");
            convertToRoman(21).Should().Be("XXI");
            convertToRoman(24).Should().Be("XXIV");
            convertToRoman(25).Should().Be("XXV");
            convertToRoman(28).Should().Be("XXVIII");
            convertToRoman(29).Should().Be("XXIX");
        }
        [Fact] public void testP()
        {
            convertToRoman(30).Should().Be("XXX");
            convertToRoman(31).Should().Be("XXXI");
            convertToRoman(34).Should().Be("XXXIV");
            convertToRoman(35).Should().Be("XXXV");
            convertToRoman(38).Should().Be("XXXVIII");
            convertToRoman(39).Should().Be("XXXIX");
        }

        [Fact] public void testQ()
        {
            convertToRoman(40).Should().Be("XL");
            convertToRoman(41).Should().Be("XLI");
            convertToRoman(44).Should().Be("XLIV");
            convertToRoman(45).Should().Be("XLV");
            convertToRoman(48).Should().Be("XLVIII");
            convertToRoman(49).Should().Be("XLIX");
        }

        [Fact] public void testR()
        {
            convertToRoman(50).Should().Be("L");
            convertToRoman(51).Should().Be("LI");
            convertToRoman(54).Should().Be("LIV");
            convertToRoman(55).Should().Be("LV");
            convertToRoman(58).Should().Be("LVIII");
            convertToRoman(59).Should().Be("LIX");
        }

        [Fact] public void testT()
        {
            convertToRoman(60).Should().Be("LX");
            convertToRoman(71).Should().Be("LXXI");
            convertToRoman(84).Should().Be("LXXXIV");
            convertToRoman(99).Should().Be("XCIX");
        }
        /*
        [Fact]
        "C", 100
        "CCCXXXIII", 333
        CDXLIV, 444
        DCCCLXXXVIII, 888
        CMXCIX, 999*/

        private string convertToRoman(int numberToConvert)
        {
            var romanNumberAsString = "";
            var units = numberToConvert % 10;
            var tens = numberToConvert / 10 % 10;

            romanNumberAsString = ConvertDigit(tens, romanNumberAsString, "X", "L", "C");
            romanNumberAsString = ConvertDigit(units, romanNumberAsString, "I", "V", "X");
            return romanNumberAsString;
        }

        private string ConvertDigit(int numberToConvert, string romanNumberAsString, string one, string five, string ten)
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