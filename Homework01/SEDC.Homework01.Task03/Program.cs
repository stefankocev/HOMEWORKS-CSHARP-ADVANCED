using System;
using System.Threading;

namespace SEDC.Homework01.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK 3
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Stats");
            Console.WriteLine("3. Exit");

            bool userInputToNumber = int.TryParse(Console.ReadLine(), out int userInput);
            if (userInputToNumber)
            {
                switch (userInput)
                {
                    case 1:
                        PlayAGame();
                        break;
                    case 2:
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
            #endregion
            Console.ReadLine();
        }

        public static void PlayAGame()
        {
            Console.WriteLine("Please choose one of the options:");
            Console.WriteLine("1.Rock, 2.Paper, 3.Scissors");
            bool userInputToNumber = int.TryParse(Console.ReadLine(), out int userInput);
            Random random = new Random();
            int computerPick = random.Next(0, 3);
            int userScore = 0;
            int computerScore = 0;
            if (userInputToNumber)
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("You chose rock");
                        break;
                    case 2:
                        Console.WriteLine("You chose paper");
                        break;
                    case 3:
                        Console.WriteLine("You chose scissors");
                        break;
                }
                Console.WriteLine("Now computer is choosing...");
                Thread.Sleep(1500);
                switch (computerPick)
                {
                    case 1:
                        Console.WriteLine("Computer chose rock");
                        break;
                    case 2:
                        Console.WriteLine("Computer chose paper");
                        break;
                    case 3:
                        Console.WriteLine("Computer chose scissors");
                        break;
                }
                Thread.Sleep(1000);
                Console.WriteLine("Let the game begin...");
                Thread.Sleep(2000);
                Console.WriteLine("The winner is:");
                Thread.Sleep(1000);
                if ((userInput == 1 && computerPick == 2) || (userInput == 2 && computerPick == 3) || (userInput == 3 && computerPick == 1))
                {
                    Console.WriteLine("Computer :'(");
                    computerScore++;
                }

                else if ((userInput == 1 && computerPick == 3) || (userInput == 2 && computerPick == 1) || (userInput == 3 && computerPick == 2))
                {
                    Console.WriteLine(":) YOU :)");
                    userScore++;
                }

                else
                    Console.WriteLine("It's a tie :(");
            }
            Console.WriteLine($"Computer:{computerScore}, User: {userScore}");
        }
    }
    }
