using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools t = new Tools();
            Score s = new Score();

            int Win = 0;
            int Lose = 0;
            int Draw = 0;
            int Plays = 0;

            Console.Title = t.Rock + " " + t.Paper + " " + t.Scissors + " " + t.Lizard + " " + t.Spock + ": The Game by Darren Smith";
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                Console.Title = (t.Rock + " " + t.Paper + " " + t.Scissors + " " + t.Lizard + " " + t.Spock + ": The Game by Darren Smith - Score [Win " + Win + "] [Draw " + Draw + "] [Lose " + Lose + "]");
                Random random = new Random();
                int ComputerAttempt = random.Next(1, 6);

                while (s.UserAttempt <= 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("DEBUG: Score: [Win {0}] [Draw {1}] [Lose {2}] [Total {3}]",Win,Draw,Lose,Plays);
                    Console.ResetColor();
                    Console.WriteLine("\nWelcome to {0}, {1}, {2}, {3}, {4}\n", t.Rock, t.Paper, t.Scissors, t.Lizard, t.Spock);
                    Console.WriteLine("{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n{8}: {9}\n", t.SelOne, t.Rock, t.SelTwo, t.Paper, t.SelThree, t.Scissors, t.SelFour, t.Lizard, t.SelFive, t.Spock);

                    Console.Write("Please make a selection ({0} to {1}): ", t.SelOne, t.SelFive);
                    string userInput = Console.ReadLine();
                    if (!int.TryParse(userInput, out s.UserAttempt))
                    {
                        continue;
                    }
                    s.UserAttempt = Int32.Parse(userInput);
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("DEBUG: Computer seletected: {0} - ", ComputerAttempt);

                    if (ComputerAttempt == 1)
                    {
                        Console.Write(t.Rock + "\n");
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write(t.Paper + "\n");
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write(t.Scissors + "\n");
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write(t.Lizard + "\n");
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write(t.Spock + "\n");
                    }
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("DEBUG: {0} seletected: {1} - ",userName, s.UserAttempt);

                    if (s.UserAttempt == 1)
                    {
                        Console.Write(t.Rock + "\n");
                        break;
                    }
                    if (s.UserAttempt == 2)
                    {
                        Console.Write(t.Paper + "\n");
                        break;
                    }
                    if (s.UserAttempt == 3)
                    {
                        Console.Write(t.Scissors + "\n");
                        break;
                    }
                    if (s.UserAttempt == 4)
                    {
                        Console.Write(t.Lizard + "\n");
                        break;
                    }
                    if (s.UserAttempt == 5)
                    {
                        Console.Write(t.Spock + "\n");
                        break;
                    }
                    if (s.UserAttempt >= 5)
                    {
                        PrintColourMessage(ConsoleColor.Red, "ERROR\nDEGUG: Please enter a number between 1 and 5\nDEBUG: Press any key");
                        Console.ReadKey();
                        s.UserAttempt = 0;
                    }
                }
                Console.ResetColor();
                if (s.UserAttempt == 1)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} smashes {0} but nothing really happens",t.Rock);
                        Draw = Draw + 1;
                        Plays = Plays + 1;
                        scoreDrawFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} covers {1}", t.Paper, t.Rock);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} breaks {1}", t.Rock, t.Scissors);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\n{0} squashes {1}", t.Rock, t.Lizard);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\n{0} vaporises {1}", t.Spock, t.Rock);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                }
                if (s.UserAttempt == 2)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} covers {1}", t.Paper,t.Rock);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} rubs against {0}", t.Paper);
                        Draw = Draw + 1;
                        Plays = Plays + 1;
                        scoreDrawFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} cut {1}", t.Scissors,t.Paper);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\n{0} eats {1}", t.Lizard,t.Paper);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\n{0} disproves {1}", t.Paper,t.Spock);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                }
                if (s.UserAttempt == 3)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} breaks {1}", t.Rock,t.Scissors);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} cut {1}", t.Scissors,t.Paper);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} just rub together creating sparks",t.Scissors);
                        Draw = Draw + 1;
                        Plays = Plays + 1;
                        scoreDrawFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\n{0} decapitates {1}", t.Scissors,t.Lizard);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\n{0} smashes {1}", t.Spock,t.Scissors);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                }
                if (s.UserAttempt == 4)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} crushes {1}", t.Rock,t.Lizard);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} eats {1}", t.Lizard,t.Paper);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} decapitates {1}", t.Scissors,t.Lizard);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\nThe {0} starts reproducing", t.Lizard);
                        Draw = Draw + 1;
                        Plays = Plays + 1;
                        scoreDrawFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\n{0} poisons {1}", t.Lizard,t.Spock);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                }
                if (s.UserAttempt == 5)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} vaporizes {1}", t.Spock,t.Rock);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} disproves {1}", t.Paper,t.Spock);
                        Lose = Lose + 1;
                        Plays = Plays + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} smashes {1}", t.Spock,t.Scissors);
                        Win = Win + 1;
                        Plays = Plays + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\n{0} poisons {1}", t.Lizard,t.Spock);
                        Lose = Lose + 1; Plays = Plays + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\nLive long and prosper");
                        Draw = Draw + 1; Plays = Plays + 1;
                        scoreDrawFun();
                    }
                }
            }
        }
        public static void scoreWinFun()
        {
            PrintColourMessage(ConsoleColor.Green, " Win");
            Score s = new Score();
            s.UserAttempt = 0;
            retryMess();
        }
        public static void scoreDrawFun()
        {
            PrintColourMessage(ConsoleColor.Yellow, " Draw");
            Score s = new Score();
            s.UserAttempt = 0;
            retryMess();
            
        }
        public static void scoreLoseFun()
        {
            PrintColourMessage(ConsoleColor.Red, " Lose");
            Score s = new Score();
            s.UserAttempt = 0;
            retryMess();
        }
        static void retryMess()
        {
            Console.WriteLine("Press any key to try again");
            Console.ReadKey();
        }
        static void PrintColourMessage(ConsoleColor color, String message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.WriteLine("");
            Console.ResetColor();
        }
    }
}
   
