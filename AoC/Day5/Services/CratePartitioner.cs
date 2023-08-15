using AoC.Day5.Models;

namespace AoC.Day5.Services
{
    public class CratePartitioner
    {
        public CrateSections SplitStuff(string input)
        {
            CrateSections returnValue = new CrateSections();
            string[] splitter = input.Split(' ');
            foreach(var findOutIdk in splitter)
            {
                bool isInt = int.TryParse(findOutIdk, out int namingIsHard);
                if (isInt)
                {
                    if(returnValue.AmountToMove == 0)
                    {
                        returnValue.AmountToMove = namingIsHard;
                    }else if(returnValue.WhereToMoveFrom == 0)
                    {
                        returnValue.WhereToMoveFrom = namingIsHard;
                    }else if(returnValue.WhereToMoveTo == 0)
                    {
                        returnValue.WhereToMoveTo = namingIsHard;
                    }

                }
            }

            return returnValue;
        }
    }
}
