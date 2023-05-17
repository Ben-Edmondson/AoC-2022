using Moq;
using AoC;
namespace AoCTests
{
    public class UppereCalculationsTest
    {
        private UppercaseCalculations uppercaseCalculation = new UppercaseCalculations();

        List<char> Inputs = new List<char>()
        {
            'p','L','P','v','t','s'
        };
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void UpperCaseCalcGetsCorrectResult()
        {
            int result = uppercaseCalculation.GetUppercasePriorityTotal(Inputs);

            Assert.That(result, Is.EqualTo(80));
        }
    }
}
