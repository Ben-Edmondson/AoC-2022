using Moq;
using AoC;
namespace AoCTests
{
    public class LowerCaseCalculationsTest
    {
        private LowercaseCalculation lowercaseCalculation = new LowercaseCalculation();

        List<char> Inputs = new List<char>()
        {
            'p','L','P','v','t','s'
        };
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void LowerCaseCalcGetsCorrectResult()
        {
            int result = lowercaseCalculation.GetLowercasePriorityTotal(Inputs);

            Assert.That(result, Is.EqualTo(77));
        }
    }
}
