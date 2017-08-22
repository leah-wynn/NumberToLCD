using System;
using Xunit;
using NumbersToLCD2.Production;

namespace NumbersToLCD2
{
    public class UnitTest1
    {
        [Fact]
        public void NumberOneShouldEqualLCDOne()
        {
            NumbersToLCD translateNumber = new NumbersToLCD("1");
            Assert.Equal("   \n" +
                         "  |\n" +
                         "  |", translateNumber.NumberToString());

        }

        [Fact]
        public void NumberTwoShouldEqualLCDTwo()
        {
            NumbersToLCD translateNumber = new NumbersToLCD("2");
            Assert.Equal(" _ \n" +
                         " _|\n" +
                         "|_ ", translateNumber.NumberToString());
        }
		[Fact]
		public void NumberThreeShouldEqualLCDThree()
		{
			NumbersToLCD translateNumber = new NumbersToLCD("3");
			Assert.Equal(" _ \n" +
						 " _|\n" +
						 " _|", translateNumber.NumberToString());
		}
        [Fact]
        public void DoubleDigitIntShouldReturnDoubleDigitLCD()
        {
            NumbersToLCD translateNumber = new NumbersToLCD("12");
            Assert.Equal("    _ \n" +
                         "  | _|\n" +
                         "  ||_ ", translateNumber.NumberToString());
        }
    }
}
