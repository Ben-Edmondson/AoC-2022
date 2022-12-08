Console.WriteLine("Day 1");
//magical energy
//star fruit
//50 needed minimum
//calories
//calculate total calories of each elf carried
//get file into array
var file = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day1\\input.txt");
//swap to list, I like lists
var strList = new List<string>(file);
var bigCal = 0;
var bigCalTwo = 0;
var bigCalThree = 0;
var currentCal = 0;
//iterate through list adding together calories once it hits a blank space.
for (int i = 0; i < strList.Count; i++)
{
    try
    {
        currentCal = currentCal + Convert.ToInt32(strList[i]);
    }
    catch
    {
        if (currentCal >= bigCal)
        {
            bigCal = currentCal;
        }else if (currentCal >= bigCalTwo)
        {
            bigCalTwo = currentCal;
        }else if (currentCal >= bigCalThree)
        {
            bigCalThree = currentCal;
        }
        currentCal = 0;   
    }
}
Console.WriteLine(bigCal);
Console.WriteLine(bigCalTwo);
Console.WriteLine(bigCalThree);
var topThreeComb = bigCal + bigCalTwo + bigCalThree;
Console.WriteLine(topThreeComb);
Console.ReadKey();
