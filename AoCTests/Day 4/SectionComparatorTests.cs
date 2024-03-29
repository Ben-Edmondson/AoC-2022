﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AoC;
using AoC.Models;
using AoC.Services;

namespace AoCTests.Day_4
{
    public class SectionComparatorTests
    {
        SectionComparator sectionComparator = new SectionComparator();
        [Test]
        public void SectionContainedTest()
        {
            int[]sectionOne = new int[] { 2, 8 };
            int[]sectionTwo = new int[] { 3, 7 };
            Sections sections = new Sections();
            sections.sectionOne = sectionOne;
            sections.sectionTwo = sectionTwo;
            bool result = sectionComparator.CompareSections(sections);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void SectionNotContainedTest()
        {
            int[] sectionOne = new int[] { 32, 80 };
            int[] sectionTwo = new int[] { 17, 79 };
            Sections sections = new Sections();
            sections.sectionOne = sectionOne;
            sections.sectionTwo = sectionTwo;
            bool result = sectionComparator.CompareSections(sections);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void SectionContainedTwoTest()
        {
            int[] sectionOne = new int[] { 6, 6 };
            int[] sectionTwo = new int[] { 4, 6 };
            Sections sections = new Sections();
            sections.sectionOne = sectionOne;
            sections.sectionTwo = sectionTwo;
            bool result = sectionComparator.CompareSections(sections);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void SectionDoesNotOverlapTest()
        {
            int[] sectionOne = new int[] { 6, 6 };
            int[] sectionTwo = new int[] { 4, 5 };
            Sections sections = new Sections();
            sections.sectionOne = sectionOne;
            sections.sectionTwo = sectionTwo;
            bool result = sectionComparator.CompareOverlap(sections);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void SectionOverlapTest()
        {
            int[] sectionOne = new int[] { 6, 6 };
            int[] sectionTwo = new int[] { 4, 7 };
            Sections sections = new Sections();
            sections.sectionOne = sectionOne;
            sections.sectionTwo = sectionTwo;
            bool result = sectionComparator.CompareOverlap(sections);

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
