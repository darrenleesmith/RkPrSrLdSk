using System; //Default
using System.Linq; //Used for Sum command

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools t = new Tools(); //Location of all tools, these can be modified in the Tools.cs
            Score s = new Score(); //Location of Scores, currently only stores UserAttempt, but will soon hold all the scores, Scores.cs

            int Win = 0; // Default zero on every turn
            int Lose = 0; // Default zero on every turn
            int Draw = 0; // Default zero on every turn

            Console.Title = t.Rock + " " + t.Paper + " " + t.Scissors + " " + t.Lizard + " " + t.Spock + ": The Game by Darren Smith"; //Console Title
            Console.Write("What is your name? "); //Asks user for their name
            string userName = Console.ReadLine(); //User input gets stored as a var "userName"
            Console.Clear(); // Clears the screen

            while (true)
            {
                Console.Title = (t.Rock + " " + t.Paper + " " + t.Scissors + " " + t.Lizard + " " + t.Spock + ": The Game by Darren Smith - User: "+ userName); //Updates the console title to include userName Var
                Random random = new Random(); 
                int ComputerAttempt = random.Next(1, 6); //Created random number between 1 and 5 and stores it in the var ComputerAttempt

                while (s.UserAttempt <= 5) // Creates a loop
                {
                    Console.Clear(); // This ensures the console is clear during every loop
                    int[] array1 = { Win, Lose, Draw }; // Total plays within loop to ensure every move is counted
                    int Plays = array1.Sum(); //var to show Score

                    PrintColourMessage(ConsoleColor.Red, "Score: [Win "+Win+"] [Draw "+Draw+"] [Lose "+Lose +"] [Total "+Plays+"]"); //Displays Score information
                    PrintColourMessage(ConsoleColor.Yellow, "Welcome to "+t.Rock+ ", "+t.Paper+ ", " + t.Scissors+ ", " + t.Lizard+ ", " + t.Spock); // Welcomes user
                    PrintColourMessage(ConsoleColor.White, t.SelOne +": "+ t.Rock +"\n"+ t.SelTwo + ": " + t.Paper +"\n"+ t.SelThree + ": " + t.Scissors +"\n"+ t.SelFour + ": " + t.Lizard+"\n" + t.SelFive + ": " + t.Spock); //shows options

                    Console.Write("Please make a selection ({0} to {1}): ", t.SelOne, t.SelFive); //Asks user to select an option.
                    string userInput = Console.ReadLine(); //User input stored in userInput
                    if (!int.TryParse(userInput, out s.UserAttempt)) //Ensures user input is a number
                    {
                        continue;
                    }
                    s.UserAttempt = Int32.Parse(userInput);

                    Console.ForegroundColor = ConsoleColor.Cyan; //Shows cpu attempt
                    Console.Write("\nComputer seletected: {0} - ", ComputerAttempt);

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

                    Console.ForegroundColor = ConsoleColor.Green; //Shows user attempt
                    Console.Write("{0} seletected: {1} - ",userName, s.UserAttempt);

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
                    if (s.UserAttempt >= 5) //Displays error if user selects a number higher than 5
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
                        scoreDrawFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} covers {1}", t.Paper, t.Rock);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} breaks {1}", t.Rock, t.Scissors);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\n{0} squashes {1}", t.Rock, t.Lizard);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\n{0} vaporises {1}", t.Spock, t.Rock);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                }
                if (s.UserAttempt == 2)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} covers {1}", t.Paper,t.Rock);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} rubs against {0}", t.Paper);
                        Draw = Draw + 1;
                        scoreDrawFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} cut {1}", t.Scissors,t.Paper);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\n{0} eats {1}", t.Lizard,t.Paper);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\n{0} disproves {1}", t.Paper,t.Spock);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                }
                if (s.UserAttempt == 3)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} breaks {1}", t.Rock,t.Scissors);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} cut {1}", t.Scissors,t.Paper);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} just rub together creating sparks",t.Scissors);
                        Draw = Draw + 1;
                        scoreDrawFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\n{0} decapitates {1}", t.Scissors,t.Lizard);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\n{0} smashes {1}", t.Spock,t.Scissors);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                }
                if (s.UserAttempt == 4)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} crushes {1}", t.Rock,t.Lizard);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} eats {1}", t.Lizard,t.Paper);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} decapitates {1}", t.Scissors,t.Lizard);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\nThe {0} starts reproducing", t.Lizard);
                        Draw = Draw + 1;
                        scoreDrawFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\n{0} poisons {1}", t.Lizard,t.Spock);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                }
                if (s.UserAttempt == 5)
                {
                    if (ComputerAttempt == 1)
                    {
                        Console.Write("\n{0} vaporizes {1}", t.Spock,t.Rock);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 2)
                    {
                        Console.Write("\n{0} disproves {1}", t.Paper,t.Spock);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 3)
                    {
                        Console.Write("\n{0} smashes {1}", t.Spock,t.Scissors);
                        Win = Win + 1;
                        scoreWinFun();
                    }
                    if (ComputerAttempt == 4)
                    {
                        Console.Write("\n{0} poisons {1}", t.Lizard,t.Spock);
                        Lose = Lose + 1;
                        scoreLoseFun();
                    }
                    if (ComputerAttempt == 5)
                    {
                        Console.Write("\nLive long and prosper");
                        Draw = Draw + 1;
                        scoreDrawFun();
                    }
                }
            }
        }
        public static void scoreWinFun() //Method for when a user wins
        {
            PrintColourMessage(ConsoleColor.Green, " Win");
            retryMess();
        }
        public static void scoreDrawFun() //Method for when a user draws
        {
            PrintColourMessage(ConsoleColor.Yellow, " Draw");
            retryMess();
            
        }
        public static void scoreLoseFun() //Method for when a user loses
        {
            PrintColourMessage(ConsoleColor.Red, " Lose");
            retryMess();
        }
        static void retryMess() //Restarts game
        {
            Score s = new Score();
            s.UserAttempt = 0;
            Console.WriteLine("Press any key to try again");
            Console.ReadKey();
        }
        static void PrintColourMessage(ConsoleColor color, String message) //Method to clear up formatting to avoid duplication
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message+"\n");
            Console.ResetColor();
        }
    }
}
   
