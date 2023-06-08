using AoC.Models;

namespace AoC.Services
{
    public class SectionSplitter
    {

        public Sections splitSection(string input)
        {
            string[] splitter = input.Split(',');
            string sectionOne = splitter[0];
            string sectionTwo = splitter[1];
            Sections sections = new Sections();
            sections.sectionOne = Parser(sectionOne);
            sections.sectionTwo = Parser(sectionTwo);
            return sections;
        }

        public int[] Parser(string section)
        {
            int[] sectionParsed = new int[2];
            string[] divider = section.Split('-');
            sectionParsed[0] = int.Parse(divider[0]);
            sectionParsed[1] = int.Parse(divider[1]);
            return sectionParsed;

        }
    }
}
