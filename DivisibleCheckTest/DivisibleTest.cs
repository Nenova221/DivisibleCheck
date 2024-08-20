namespace DivisibleCheckTest
{
    public class DivisibleTest
    {
        [Theory]
        [InlineData(36587, false)]
        [InlineData(69725, true)]
        [InlineData(3889587, false)]

        public void Checking_WithIsThirdDigitSeven_ShouldReturnTheCorrectResult(int input, bool expected)
        {
            bool result = DivisibleCheck.Checking(input, expected);
            Assert.Equal(expected, result);
        }
    }
}