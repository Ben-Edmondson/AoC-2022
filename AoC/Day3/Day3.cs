namespace AoC
{
    public class Day3
    {
        //Rucksacks with supplies
        //2 large compartments
        //all items of a given type go into one of the compartments
        //this rule has been failed for 1 item type per rucksack
        //Item yupes are identified by a lower or uppercase letter.
        //a and A are 2 different types of items for example
        // a-z have prio 1-26
        //A-Z has prio 27-52

        //split string in half

        //loop through each character of the first half, compare vs each letter of the second half till a match is found.
        // when found do priority calculation

        StringSplit StringSplit = new StringSplit();
        UppercaseCalculations upperCalculations = new UppercaseCalculations();
        LowercaseCalculation lowerCalculations = new LowercaseCalculation();
        public void day3()
        {
            var inputs = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day3\\Day3.txt");
            int lowerCaseNumbers = upperCalculations.GetUppercasePriorityTotal(StringSplit.stringSplit(inputs));
            int upperCaseNumbers = lowerCalculations.GetLowercasePriorityTotal(StringSplit.stringSplit(inputs));
            int result = lowerCaseNumbers + upperCaseNumbers;

            Console.WriteLine(result);
            Console.ReadLine();
        }


    

    }
}
