using AoC;
namespace AoCTests
{
    public class StringSplitTests
    {

        [Test]
        public void DoesStringSplitCorrectlyGetRightCharacters()
        {
            CompartmentSplitter stringSplit = new CompartmentSplitter();
            string[] inputs = {
            "vJrwpWtwJgWrhcsFMMfFFhFp",
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
            "PmmdzqPrVvPwwTWBwg",
            "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
            "ttgJtRGJQctTZtZT",
            "CrZsJsPPZsGzwwsLwLmpwMDw"};
            List<char> charsToTest = stringSplit.StringSplit(inputs);

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