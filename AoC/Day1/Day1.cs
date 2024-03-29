﻿namespace AoC
{
    public class Day1
    {
        public void day1()
        {

            Console.WriteLine("Day 1");

            var file = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day1\\input.txt");
            var strList = new List<string>(file);
            var bigCal = 0;
            var bigCalTwo = 0;
            var bigCalThree = 0;
            var currentCal = 0;
            for (int i = 0; i < strList.Count; i++)
            {
                if (int.TryParse(strList[i], out int calories))
                {
                    currentCal = currentCal + calories;
                }

                if (!int.TryParse(strList[i], out _) || i == strList.Count - 1)
                {
                    if (currentCal >= bigCal)
                    {
                        bigCalThree = bigCalTwo;
                        bigCalTwo = bigCal;
                        bigCal = currentCal;
                    }
                    else if (currentCal >= bigCalTwo)
                    {
                        bigCalThree = bigCalTwo;
                        bigCalTwo = currentCal;
                    }
                    else if (currentCal >= bigCalThree)
                    {
                        bigCalThree = currentCal;
                    }
                    currentCal = 0;
                }
            }

            var topThreeComb = bigCal + bigCalTwo + bigCalThree;
            Console.WriteLine($"Part one answer: {bigCal}");
            Console.WriteLine($"Part two answer: {topThreeComb}");
            Console.ReadKey();
        }
    }
}