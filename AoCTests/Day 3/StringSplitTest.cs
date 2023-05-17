using AoC;
namespace AoCTests
{
    public class StringSplitTests
    {

        [Test]
        public void DoesStringSplitCorrectlyGetRightCharacters()
        {
            StringSplit stringSplit = new StringSplit();
            string[] inputs = {
            "vJrwpWtwJgWrhcsFMMfFFhFp",
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
            "PmmdzqPrVvPwwTWBwg",
            "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
            "ttgJtRGJQctTZtZT",
            "CrZsJsPPZsGzwwsLwLmpwMDw"};
            List<char> charsToTest = stringSplit.stringSplit(inputs);

                if (charsToTest.Contains('p') &&
                    charsToTest.Contains('L') &&
                    charsToTest.Contains('P') &&
                    charsToTest.Contains('v') &&
                    charsToTest.Contains('t') &&
                    charsToTest.Contains('s'))
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                };
        }
    }
}