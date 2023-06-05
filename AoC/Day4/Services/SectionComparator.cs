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


        public int CompareSections(Sections sections)
        {
            int containedCounter = 0;
            int sectionOneStart = sections.sectionOne[0];
            int sectionOneEnd = sections.sectionOne[1];

            int sectionTwoStart = sections.sectionTwo[0];
            int sectionTwoEnd = sections.sectionTwo[1];

            if( sectionOneStart <= sectionTwoStart )
            {
                if(sectionTwoStart <= sectionOneEnd )
                {
                    if(sectionTwoEnd <= sectionOneEnd)
                    {
                        containedCounter = 1;
                    }
                }
            }else if(sectionTwoStart <= sectionOneStart ) 
            {
                if(sectionOneStart <= sectionTwoEnd ) 
                {
                    if(sectionOneEnd <= sectionTwoEnd)
                    {
                        containedCounter = 1;
                    }
                }
            }
            return containedCounter;
        }
    }
}
