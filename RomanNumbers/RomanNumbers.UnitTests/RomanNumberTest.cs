using FluentAssertions;
using Xunit;
using RomanNumbers.Logic;

namespace RomanNumbers.UnitTests
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

        [Fact] public void testU()
        {
            convertToRoman(100).Should().Be("C");
            convertToRoman(333).Should().Be("CCCXXXIII");
            convertToRoman(444).Should().Be("CDXLIV");
            convertToRoman(888).Should().Be("DCCCLXXXVIII");
            convertToRoman(999).Should().Be("CMXCIX");
        }

        private string convertToRoman(int numberToConvert) =>
            new RomanNumberTextRepresentation().ConvertToRoman(numberToConvert);
    }
}