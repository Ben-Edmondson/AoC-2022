namespace AoC
{
    public class Day3
    {

        CompartmentSplitter compartmentSplitter = new CompartmentSplitter();
        UppercaseCalculations upperCalculations = new UppercaseCalculations();
        LowercaseCalculation lowerCalculations = new LowercaseCalculation();
        FindCommonChar findCommonChar= new FindCommonChar();
        ElfSplitter elfSplitter = new ElfSplitter();
        public void Day3Solution()
        {
            var inputs = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day3\\Day3.txt");
            var compartments = compartmentSplitter.StringSplit(inputs);
            int lowerCaseNumbers = upperCalculations.GetUppercasePriorityTotal(compartments);
            int upperCaseNumbers = lowerCalculations.GetLowercasePriorityTotal(compartments);
            int result = lowerCaseNumbers + upperCaseNumbers;

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public void Day3Part2Solution()
        {
            var inputs = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day3\\Day3.txt");
            var groupedElves = elfSplitter.Elves(inputs);
            var lowerList = new List<char>();
            var upperList = new List<char>();
            foreach(var group in groupedElves)
            {
                upperList.AddRange(findCommonChar.FindUppercaseCommonCharacter(group));
                lowerList.AddRange(findCommonChar.FindLowercaseCommonCharacter(group));
            }
            int lowerCaseNumbers = upperCalculations.GetUppercasePriorityTotal(upperList);
            int upperCaseNumbers = lowerCalculations.GetLowercasePriorityTotal(lowerList);
            int result = lowerCaseNumbers + upperCaseNumbers;
            Console.WriteLine(result);
            Console.ReadLine();
        }




    }
}
