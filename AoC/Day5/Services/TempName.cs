using AoC.Day5.Models;
using System.Runtime.CompilerServices;

namespace AoC.Day5.Services
{
    public class TempName
    {
        public CrateSections SplitStuff(string input)
        {
            CrateSections returnValue = new CrateSections();
            string[] splitter = input.Split(' ');
            foreach(var findOutIdk in splitter)
            {
                bool isInt = int.TryParse(findOutIdk, out int heheXD);
                if (isInt)
                {
                    if(returnValue.AmountToMove == 0)
                    {
                        returnValue.AmountToMove = heheXD;
                    }else if(returnValue.WhereToMoveFrom == 0)
                    {
                        returnValue.WhereToMoveFrom = heheXD;
                    }else if(returnValue.WhereToMoveTo == 0)
                    {
                        returnValue.WhereToMoveTo = heheXD;
                    }

                }
            }

            return returnValue;
        }
    }
}
