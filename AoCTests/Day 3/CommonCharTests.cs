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

            commonChar.FindUppercaseCommonCharacter(elves);
            Assert.That(commonChar.charList.Contains('G'));

        }

    }
}
