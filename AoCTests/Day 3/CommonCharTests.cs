using AoC;

namespace AoCTests.Day_3
{
    public class CommonCharTests
    {
        FindCommonChar commonChar = new FindCommonChar();

        [Test]
        public void ListContainsLetterWhenPresentInAllThreeStrings()
        {
            string[] elves =
            {
                "ahGnB",
                "gebHG",
                "lGioP"
            };

            List<char> elvesList = commonChar.FindUppercaseCommonCharacter(elves);
            Assert.That(elvesList.Contains('G'));

        }

    }
}
