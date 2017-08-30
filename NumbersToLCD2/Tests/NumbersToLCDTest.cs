using Xunit;

namespace NumbersToLCD2
{
    public class UnitTest1
    {
        [Fact]
        public void NumberOneShouldEqualLCDOne()
        {
            NumbersToLCD number = new NumbersToLCD();
            Assert.Equal("   \n" +
                         "  |\n" +
                         "  |", number.ToLCD(1));

        }

        [Fact]
        public void NumberTwoShouldEqualLCDTwo()
        {
            NumbersToLCD number = new NumbersToLCD();
            Assert.Equal(" _ \n" +
                         " _|\n" +
                         "|_ ", number.ToLCD(2));
        }
        [Fact]
        public void DoubleDigitIntShouldReturnDoubleDigitLCD()
        {
            NumbersToLCD number = new NumbersToLCD();
            Assert.Equal("    _ \n" +
                         "  | _|\n" +
                         "  ||_ ", number.ToLCD(12));
        }
    }
}
