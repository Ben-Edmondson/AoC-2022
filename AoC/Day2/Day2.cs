namespace AoC
{
    public class Day2
    {
        public void day2()
        {
            var file = File.ReadAllLines("C:\\dev\\PayCalc\\AoC\\AoC\\Day2\\input.txt");
            var strList = new List<string>(file);
            //part 1
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
            //part 2
            score = 0;
            foreach(var turns in strList)
            {
                //X lose, Y Draw, Z Win
                var whatsPlayed = turns.Substring(0, 1);
                var winYesNo = turns.Substring(2, 1);
                if (whatsPlayed == "A")
                {
                    if (winYesNo == "X")
                    {
                        score = score + 3;
                    }
                    else if (winYesNo == "Y")
                    {
                        score = score + 4;
                    }
                    else if (winYesNo == "Z")
                    {
                        score = score + 8;
                    }
                }
                else if (whatsPlayed == "B")
                {
                    if (winYesNo == "X")
                    {
                        score = score + 1;
                    }
                    else if (winYesNo == "Y")
                    {
                        score = score + 5;
                    }
                    else if (winYesNo == "Z")
                    {
                        score = score + 9;
                    }
                }
                else if (whatsPlayed == "C")
                {
                    if (winYesNo == "X")
                    {
                        score = score + 2;
                    }
                    else if (winYesNo == "Y")
                    {
                        score = score + 6;
                    }
                    else if (winYesNo == "Z")
                    {
                        score = score + 7;
                    }
                }
            }
            Console.WriteLine(score);
            Console.ReadKey();
        }
    }
}
