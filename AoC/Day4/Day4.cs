using AoC.Models;
using AoC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC
{
    public class Day4
    {
        SectionSplitter sectionSplitter = new SectionSplitter();
        SectionComparator comparator = new SectionComparator();
        //ID number for each section
        //some sections overlap
        //some sections are completely contained by another
        //how many pairs have this issue

        //split the input into groups of 2
        //compare the sections for overlap
        //add to total pairs if there is complete overlap
        public void Day4Part1()
        {
            int counter = 0;
            var inputs = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day4\\Day4.txt");
            foreach(var line in inputs)
            {
                var sections = sectionSplitter.splitSection(line);
                
                if(comparator.CompareSections(sections) == true)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        public void Day4Part2()
        {
            int counter = 0;
            var inputs = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day4\\Day4.txt");
            foreach (var line in inputs)
            {
                var sections = sectionSplitter.splitSection(line);

                if (comparator.CompareOverlap(sections) == true)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
