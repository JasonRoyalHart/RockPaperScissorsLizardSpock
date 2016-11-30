using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public int numPlayers;
        public bool gameOver;
        public Player player;
        public Player playerTwo;
        public void GameStart()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Play will be to best of three.");
            bool chosen = false;
            while (!chosen)
            {
                Console.Write("Enter one for one player or two for two players: ");
                string players = Console.ReadLine();
                switch (players)
                {
                    case "one":
                    case "1":
                        numPlayers = 1;
                        chosen = true;
                        Console.WriteLine("Set to one player mode.");
                        this.player = new Human();
                        this.playerTwo = new Computer();
                        break;
                    case "two":
                    case "2":
                        numPlayers = 2;
                        chosen = true;
                        Console.WriteLine("Set to two player mode.");
                        this.player = new Human();
                        this.playerTwo = new Human();
                        break;
                    default:
                        Console.WriteLine("Please enter one or two.");
                        break;
                }
            }
        }
        public void AdjustScores() {
            if (player.won == "yes")
            {
                player.AdjustScore(1);
            }
            else if (playerTwo.won == "yes")
            {
                playerTwo.AdjustScore(1);
            }
        }

        public void DisplayScores()
        {
            Console.WriteLine("{0} score: {1}. {2} score: {3}", player.name, player.score, playerTwo.name, playerTwo.score);
        }
        public void SetWinnerAndLoser(string playerWon, string playerTwoWon) {
            player.won = playerWon;
            playerTwo.won = playerTwoWon;
        }

        public void CompareChoices()
        {
            switch (player.choice)
            {
                case "rock":
                    {
                        switch (playerTwo.choice)
                        {
                            case "paper":
                                Console.WriteLine("Paper covers rock.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                            case "rock":
                                Console.WriteLine("Rock clashes with rock.");
                                SetWinnerAndLoser("tie", "tie");
                                break;
                            case "scissors":
                                Console.WriteLine("Rock breaks scissors.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                            case "lizard":
                                Console.WriteLine("Rock crushes lizard.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                            case "spock":
                                Console.WriteLine("Spock vaporizes rock.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                        }
                        break;
                    }
                case "paper":
                    {
                        switch (playerTwo.choice)
                        {
                            case "paper":
                                Console.WriteLine("Paper clashes with paper.");
                                SetWinnerAndLoser("tie", "tie");
                                break;
                            case "rock":
                                Console.WriteLine("Paper covers rock.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                            case "scissors":
                                Console.WriteLine("Scissors cuts paper.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                            case "lizard":
                                Console.WriteLine("Lizard eats paper.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                            case "spock":
                                Console.WriteLine("Spock is disproven by paper.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                        }
                        break;
                    }
               case "scissors":
                    {
                        switch (playerTwo.choice)
                        {
                            case "paper":
                                Console.WriteLine("Scissors cuts paper.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                            case "rock":
                                Console.WriteLine("Rock crushes scissors.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                            case "scissors":
                                Console.WriteLine("Scissors clashes with scissors.");
                                SetWinnerAndLoser("tie", "tie");
                                break;
                            case "lizard":
                                Console.WriteLine("Scissors decapitates lizard.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                            case "spock":
                                Console.WriteLine("Spock smashes scissors.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                        }
                        break;
                    }
                case "lizard":
                    {
                        switch (playerTwo.choice)
                        {
                            case "paper":
                                Console.WriteLine("Lizard eats paper.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                            case "rock":
                                Console.WriteLine("Rock crushes lizard.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                            case "scissors":
                                Console.WriteLine("Scissors decapitates lizard.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                            case "lizard":
                                Console.WriteLine("Lizard clashes with lizard.");
                                SetWinnerAndLoser("tie", "tie");
                                break;
                            case "spock":
                                Console.WriteLine("Lizard poisons Spock.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                        }
                        break;
                    }
                case "spock":
                    {
                        switch (playerTwo.choice)
                        {
                            case "paper":
                                Console.WriteLine("Paper disproves Spock.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                            case "rock":
                                Console.WriteLine("Spock vaporizes rock.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                            case "scissors":
                                Console.WriteLine("Spock smashes scissors.");
                                SetWinnerAndLoser("yes", "no");
                                break;
                            case "lizard":
                                Console.WriteLine("Lizard poisons Spock.");
                                SetWinnerAndLoser("no", "yes");
                                break;
                            case "spock":
                                Console.WriteLine("Spock clashes with Spock.");
                                SetWinnerAndLoser("tie", "tie");
                                break;
                        }
                        break;
                    }
            }
            AdjustScores();
            DisplayScores();
        }


        public void GetNames()
        {
            Console.Write("Player one, please enter your name: ");
            player.name = Console.ReadLine();
            if (numPlayers == 2)
            {
                Console.Write("Player two, please enter your name: ");
                playerTwo.name = Console.ReadLine();
            }
        }

        public void DisplayCompetitors()
        {
            Console.WriteLine("Its {0} versus {1}!", player.name, playerTwo.name);
        }

        public void ClearScreen()
        {
            if (numPlayers == 2)
            {
                Console.WriteLine("Hit any key to clear the screen for the next player.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void Play()
        {
            GameStart();
            GetNames();
            player.playAgain = true;
            while (player.playAgain)
            {
                DisplayCompetitors();
                player.getChoice();
                ClearScreen();
                playerTwo.getChoice();
                CompareChoices();
                gameEnd();
            }
        }
        public void endLoop()
        {
            bool decided = false;
            if (player.score < 2 && playerTwo.score < 2)
            {
                decided = true;
            }
            while (!decided)
            {
                Console.Write("Play again? ");
                string playing = Console.ReadLine().ToLower();
                switch (playing)
                {
                    case "y":
                    case "ye":
                    case "yes":
                        player.playAgain = true;
                        Console.WriteLine("Great! I love a challenge!");
                        decided = true;
                        player.score = playerTwo.score = 0;
                        break;
                    case "n":
                    case "no":
                        player.playAgain = false;
                        Console.WriteLine("Too bad. You were a worthy opponent.");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                        decided = true;
                        gameOver = true;
                        break;
                    default:
                        Console.WriteLine("Please answer yes or no.");
                        break;

                }
            }

        }

        public void gameEnd()
        {
            if (player.won == "yes")
            {
                Console.WriteLine("{0} wins. {1} loses.", player.name, playerTwo.name);
            }
            else if (player.won=="no")
            {
                Console.WriteLine("{0} wins. {1} loses.", playerTwo.name, player.name);

            }
            else
            {
                Console.WriteLine("You tie.");
            }
            endLoop();
        }


    }
}