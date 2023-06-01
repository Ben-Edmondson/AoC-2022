using AoC.Day4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoCTests.Day_4
{
    public class SectionComparatorTests
    {
        SectionComparator sectionComparator = new SectionComparator();
        [Test]
        public void SectionOverlapsTest()
        {
            int[]sectionOne = new int[] { 1, 10 };
            int[]sectionTwo = new int[] { 2, 5 };

            int result = sectionComparator.CompareSections(sectionOne, sectionTwo);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SectionDoesNotOverlapTest()
        {
            int[] sectionOne = new int[] { 1, 10 };
            int[] sectionTwo = new int[] { 11, 12 };

            int result = sectionComparator.CompareSections(sectionOne, sectionTwo);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void SectionOverlapsTwoTest()
        {
            int[] sectionOne = new int[] { 2, 4 };
            int[] sectionTwo = new int[] { 1, 5 };

            int result = sectionComparator.CompareSections(sectionOne, sectionTwo);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
