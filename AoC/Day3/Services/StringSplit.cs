using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC
{
    public class StringSplit
    {
        List<char> charsForSolution = new List<char>();


        public List<char> stringSplit()
        {
            var inputs = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day3\\Day3.txt");

            foreach (string input in inputs)
            {
                var firstHalfLength = input.Length / 2;
                var secondHalfLength = input.Length - firstHalfLength;
                var compOne = input.Substring(0, firstHalfLength);
                var compTwo = input.Substring(firstHalfLength, secondHalfLength);
                List<char> checkedItems = new List<char>();
                foreach (char item in compOne)
                {
                    if (!checkedItems.Contains(item))
                    {
                        foreach (char compItem in compTwo)
                        {
                            if (item == compItem)
                            {
                                checkedItems.Add(item);
                                charsForSolution.Add(item);
                                break;
                            }
                        }
                    }
                }
                checkedItems.Clear();
            }
            return charsForSolution;
        }
    }
}
