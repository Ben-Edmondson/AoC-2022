using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Day4.Services
{
    public class SectionComparator
    {


        public int CompareSections(int[]sectionOne, int[] sectionTwo)
        {
            int containedCounter = 0;
            int sectionOneStart = sectionOne[0];
            int sectionOneEnd = sectionOne[1];
            int sectionTwoStart = sectionTwo[0];
            int sectionTwoEnd = sectionTwo[1];
            if( sectionOneStart < sectionTwoStart )
            {
                if(sectionTwoStart < sectionOneEnd )
                {
                    if(sectionTwoEnd < sectionOneEnd)
                    {
                        containedCounter = 1;
                    }
                }
            }else if(sectionTwoStart < sectionOneStart ) 
            {
                if(sectionOneStart < sectionTwoEnd ) 
                {
                    if(sectionOneEnd < sectionTwoEnd)
                    {
                        containedCounter = 1;
                    }
                }
            }
            return containedCounter;
        }
    }
}
