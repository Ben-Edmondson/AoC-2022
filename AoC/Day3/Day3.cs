
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

        string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
        string uppercaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public void day3()
        {
            var inputs = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day3\\Day3.txt");

            List<char> charsForSolution = new List<char>();
            var sumOfPriority = 0;
            foreach (string input in inputs)
            {
                var firstHalfLength = input.Length / 2;
                var secondHalfLength = input.Length - firstHalfLength;
                var compOne = input.Substring(0, firstHalfLength);
                var compTwo = input.Substring(firstHalfLength, secondHalfLength);
                List<char> checkedItems = new List<char>();
                foreach(char item in compOne)
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

            var numberAssigned = 1;

            foreach (char letter in lowercaseAlphabet)
            {

                if (charsForSolution.Contains(letter))
                {
                    sumOfPriority = sumOfPriority + numberAssigned;
                }
                numberAssigned++;
            }

            numberAssigned = 27;

            foreach (char letter in uppercaseAlphabet) 
            {
                if (charsForSolution.Contains(letter))
                {
                    sumOfPriority = sumOfPriority + numberAssigned;
                }
                numberAssigned++;
            }
            Console.WriteLine(sumOfPriority);
            Console.ReadLine();
        }


    

    }
}
