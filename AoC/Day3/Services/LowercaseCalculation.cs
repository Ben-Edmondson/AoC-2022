using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC
{
    public class LowercaseCalculation
    {
        string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
        
        public int GetLowercasePriorityTotal(List<char> charsForSolution)
        {
            int sumOfPriority = 0;
            var numberAssigned = 1;

            foreach (char letter in lowercaseAlphabet)
            {
                foreach(char input in charsForSolution)
                {
                    if(letter == input)
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
