namespace AoC
{
    public class Day2
    {
        public void day2()
        {
            var file = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day2\\input.txt");
            var strList = new List<string>(file);
            //1 point for rock play
            //2 points for paper play
            //3 points for scissors play
            //3 more for draw
            //6 for a win
            //0 for a loss
            var score = 0;
            foreach(var str in strList)
            {
                var elfTurn = str.Substring(0, 1);
                var yourTurn = str.Substring(2, 1);
                if (elfTurn == "A")
                {
                    if(yourTurn == "X")
                    {
                        score = score + 4;
                    }else if(yourTurn == "Y")
                    {
                        score = score + 8;
                    }else if(yourTurn == "Z")
                    {
                        score = score + 3;
                    }
                }
                else if (elfTurn == "B")
                {
                    if (yourTurn == "X")
                    {
                        score = score + 1;
                    }
                    else if (yourTurn == "Y")
                    {
                        score = score + 5;
                    }
                    else if (yourTurn == "Z")
                    {
                        score = score + 9;
                    }
                }
                else if (elfTurn == "C")
                {
                    if (yourTurn == "X")
                    {
                        score = score + 7;
                    }
                    else if (yourTurn == "Y")
                    {
                        score = score + 2;
                    }
                    else if (yourTurn == "Z")
                    {
                        score = score + 6;
                    }
                }
            }
            Console.WriteLine(score);
            Console.ReadKey();
        }
    }
}
