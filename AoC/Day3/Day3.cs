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

            foreach(var group in groupedElves)
            {
                findCommonChar.FindUppercaseCommonCharacter(group);
                findCommonChar.FindLowercaseCommonCharacter(group);
            }

            int lowerCaseNumbers = upperCalculations.GetUppercasePriorityTotal(findCommonChar.charList);
            int upperCaseNumbers = lowerCalculations.GetLowercasePriorityTotal(findCommonChar.charList);
            int result = lowerCaseNumbers + upperCaseNumbers;
            Console.WriteLine(result);
            Console.ReadLine();
        }




    }
}
