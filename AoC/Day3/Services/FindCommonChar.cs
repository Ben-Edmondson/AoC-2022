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
                if (elfTwo.Contains(item) && elfThree.Contains(item))
                {
                    if (char.IsLower(item) && !charList.Contains(item))
                    {
                        charList.Add(item);
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

            foreach(char item in elfOne)
            {
                if(elfTwo.Contains(item) && elfThree.Contains(item))
                {
                    if(char.IsUpper(item)&& !charList.Contains(item))
                    {
                        charList.Add(item);
                    }
                }
            }
            return charList;
        }
    }
}
