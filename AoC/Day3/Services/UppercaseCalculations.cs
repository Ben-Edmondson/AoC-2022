using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC
{
    public class UppercaseCalculations
    {
        string uppercaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public int GetUppercasePriorityTotal(List<char> charsForSolution)
        {
            var numberAssigned = 27;
            var sumOfPriority = 0;
            foreach (char letter in uppercaseAlphabet)
            {
                foreach (char input in charsForSolution)
                {
                    if (letter == input)
                    {
                        sumOfPriority = sumOfPriority + numberAssigned;
                    }
                }
                numberAssigned++;
            }
            return sumOfPriority;
        }
    }
}
