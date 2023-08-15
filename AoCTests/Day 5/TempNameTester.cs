using AoC.Day5.Models;
using AoC.Day5.Services;

namespace AoCTests.Day_5
{
    public class TempNameTester
    {
        TempName tempName = new TempName();
        [Test]
        public void DoesItWork()
        {

            CrateSections crateSections= new CrateSections();
            string input = "move 6 from 1 to 7";
            crateSections = tempName.SplitStuff(input);
            Assert.That(crateSections.AmountToMove, Is.EqualTo(6));
            Assert.That(crateSections.WhereToMoveFrom, Is.EqualTo(1));
            Assert.That(crateSections.WhereToMoveTo, Is.EqualTo(7));
        }
    }
}
