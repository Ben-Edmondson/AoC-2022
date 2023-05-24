using Moq;
using AoC;
namespace AoCTests
{
    public class LowerCaseCalculationsTest
    {
        private LowercaseCalculation lowercaseCalculation = new LowercaseCalculation();

        List<char> inputsNoDuplicates = new List<char>()
        {
            'p','L','P','v','t','s'
        };
        List<char> inputsWithDupes = new List<char>()
        {
            'p','L','P','v','t','s','s'
        };

        List<char> alphabetInput = new List<char>()
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
        };
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void LowerCaseCalcGetsCorrectResultWithNoDupes()
        {
            int result = lowercaseCalculation.GetLowercasePriorityTotal(inputsNoDuplicates);

            Assert.That(result, Is.EqualTo(77));
        }
        [Test]
        public void LowerCaseCalcGetsCorrectResultWithDupes()
        {
            int result = lowercaseCalculation.GetLowercasePriorityTotal(inputsWithDupes);

            Assert.That(result, Is.EqualTo(96));
        }
        [Test]
        public void LowercaseAlphabetAllCorrect()
        {
            int result = lowercaseCalculation.GetLowercasePriorityTotal(alphabetInput);

            Assert.That(result, Is.EqualTo(351));
        }
    }
}
