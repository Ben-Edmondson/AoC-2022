namespace AoC
{
    public class FindCommonChar
    {

        public List<char> charList = new List<char>();
        public void FindLowercaseCommonCharacter(string[] elves)
        {
            string elfOne = elves[0];
            string elfTwo = elves[1];
            string elfThree = elves[2];
            foreach (char item in elfOne)
            {
                foreach(char twoItem in elfTwo)
                {
                    if(item == twoItem)
                    {
                        foreach(char threeItem in elfThree)
                        {
                            if(item == threeItem)
                            {
                                charList.Add(item);
                            }
                        }
                    }
                }
            }
        }

        public void FindUppercaseCommonCharacter(string[] elves)
        {
            string elfOne = elves[0];
            string elfTwo = elves[1];
            string elfThree = elves[2];
            foreach (char item in elfOne)
            {
                foreach (char twoItem in elfTwo)
                {
                    if (item == twoItem)
                    {
                        foreach (char threeItem in elfThree)
                        {
                            if (item == threeItem)
                            {
                                charList.Add(item);
                            }
                        }
                    }
                }
            }
        }
    }
}
