using AoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Services
{
    public class SectionComparator
    {


        public bool CompareSections(Sections sections)
        {
            int sectionOneStart = sections.sectionOne[0];
            int sectionOneEnd = sections.sectionOne[1];

            int sectionTwoStart = sections.sectionTwo[0];
            int sectionTwoEnd = sections.sectionTwo[1];

            if( sectionOneStart >= sectionTwoStart && sectionOneEnd <= sectionTwoEnd )
            {
                return true;
            
            }
            else if(sectionTwoStart >= sectionOneStart && sectionTwoEnd <= sectionOneEnd ) 
            {
                return true;
            }
            return false;
        }

        public bool CompareOverlap(Sections sections)
        {
            int sectionOneStart = sections.sectionOne[0];
            int sectionOneEnd = sections.sectionOne[1];

            int sectionTwoStart = sections.sectionTwo[0];
            int sectionTwoEnd = sections.sectionTwo[1];

            if (sectionOneEnd >= sectionTwoStart && sectionTwoEnd >= sectionOneStart)
            {
                return true;

            }
            else if (sectionTwoEnd >= sectionOneStart && sectionOneEnd >= sectionTwoStart)
            {
                return true;
            }
            return false;

        }
    }
}
