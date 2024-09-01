using LEAP.HelperMethods;

namespace TestProject1
{
    public class LeapYearTests
    {
        [Test]
        public void ShouldReturnTrueWhenTheYearIs1996()
        {
            Assert.AreEqual(true, CalculatorHelper.IsLeapYear(1996));
        }

        [Test]
        public void ShouldReturnFalseWhenTheYearIs1997()
        {
            Assert.AreEqual(false, CalculatorHelper.IsLeapYear(1997));
        }

        [Test]
        public void ShouldReturnTrueWhenTheYearIs1600()
        {
            Assert.AreEqual(true, CalculatorHelper.IsLeapYear(1600));
        }

        [Test]
        public void ShouldReturnFalseWhenTheYearIs1800()
        {
            Assert.AreEqual(false, CalculatorHelper.IsLeapYear(1800));
        }
    }
}