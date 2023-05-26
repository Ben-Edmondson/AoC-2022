namespace AoC
{
    public class ElfSplitter
    {
        public string[][] Elves(string[]input)
        {
            var groupedElves = input.Select((value,index) => new {value,index})
                .GroupBy(x => x.index / 3)
                .Select(y => y.Select(x =>x.value).ToArray())
                .ToArray();

            return groupedElves;
        }
    }
}
