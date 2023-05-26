namespace AoC
{
    public class FindCommonChar
    {

        public List<char> FindLowercaseCommonCharacter(string[] elves)
        {
            List<char> charList = new List<char>();
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
                                if (char.IsLower(item))
                                {
                                    charList.Add(item);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return charList;
        }

        public List<char> FindUppercaseCommonCharacter(string[] elves)
        {
            List<char>charList = new List<char>();
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
                                if (char.IsUpper(item))
                                {
                                    charList.Add(item);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return charList;
        }
    }
}
