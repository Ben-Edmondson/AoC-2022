using Moq;
using AoC;
namespace AoCTests
{
    public class UpperCalculationsTest
    {
        private UppercaseCalculations uppercaseCalculation = new UppercaseCalculations();

        List<char> inputsWithoutDupes = new List<char>()
        {
            'p','L','P','v','t','s'
        };
        List<char> inputsWithDupes = new List<char>()
        {
            'p','L','P','v','t','s','P'
        };
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void UpperCaseCalcGetsCorrectResult()
        {
            int result = uppercaseCalculation.GetUppercasePriorityTotal(inputsWithoutDupes);

            Assert.That(result, Is.EqualTo(80));
        }
        [Test]
        public void UpperCaseCalcGetsCorrectResultWithDupes()
        {
            int result = uppercaseCalculation.GetUppercasePriorityTotal(inputsWithDupes);

            Assert.That(result, Is.EqualTo(122));
        }
    }
}
