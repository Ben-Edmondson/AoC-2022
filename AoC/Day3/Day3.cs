namespace AoC
{
    public class Day3
    {

        CompartmentSplitter compartmentSplitter = new CompartmentSplitter();
        UppercaseCalculations upperCalculations = new UppercaseCalculations();
        LowercaseCalculation lowerCalculations = new LowercaseCalculation();
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
            //elves grouped in 3s
            //badge is the only type carried by all 3
            //this means if badge == B then B will be present in all 3 elves
            //look for the only common item type in each backpack
            //split groups after every 3rd line
            //Find the common letter in each group
            //add it to list of char
            //do the priority calculation

        }


    

    }
}
