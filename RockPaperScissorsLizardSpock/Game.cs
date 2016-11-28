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
        public void gameStart()
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



        public void compareChoices()
        {
            switch (player.choice)
            {
                case "rock":
                    {
                        switch (playerTwo.choice)
                        {
                            case "paper":
                                Console.WriteLine("Paper covers rock.");
                                player.won = "no";
                                playerTwo.won = "yes";
                                break;
                            case "rock":
                                Console.WriteLine("Rock clashes with rock.");
                                player.won = "tie";
                                playerTwo.won = "tie";
                                break;
                            case "scissors":
                                Console.WriteLine("Rock breaks scissors.");
                                player.won = "yes";
                                playerTwo.won = "no";
                                break;
                            case "lizard":
                                Console.WriteLine("Rock crushes lizard.");
                                player.won = "yes";
                                playerTwo.won = "no";
                                break;
                            case "spock":
                                Console.WriteLine("Spock vaporizes rock.");
                                player.won = "no";
                                playerTwo.won = "yes";
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
                                player.won = "tie";
                                playerTwo.won = "tie";
                                break;
                            case "rock":
                                Console.WriteLine("Paper covers rock.");
                                player.won = "yes";
                                playerTwo.won = "no";
                                break;
                            case "scissors":
                                Console.WriteLine("Scissors cuts paper.");
                                player.won = "no";
                                playerTwo.won = "yes";
                                break;
                            case "lizard":
                                Console.WriteLine("Lizard eats paper.");
                                player.won = "no";
                                playerTwo.won = "yes";
                                break;
                            case "spock":
                                Console.WriteLine("Spock is disproven by paper.");
                                player.won = "yes";
                                playerTwo.won = "no";
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
                                player.won = "yes";
                                playerTwo.won = "no";
                                break;
                            case "rock":
                                Console.WriteLine("Rock crushes scissors.");
                                player.won = "no";
                                playerTwo.won = "yes";
                                break;
                            case "scissors":
                                Console.WriteLine("Scissors clashes with scissors.");
                                player.won = "tie";
                                playerTwo.won = "tie";
                                break;
                            case "lizard":
                                Console.WriteLine("Scissors decapitates lizard.");
                                player.won = "yes";
                                playerTwo.won = "no";
                                break;
                            case "spock":
                                Console.WriteLine("Spock smashes scissors.");
                                player.won = "no";
                                playerTwo.won = "yes";
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
                                player.won = "yes";
                                playerTwo.won = "no";
                                break;
                            case "rock":
                                Console.WriteLine("Rock crushes lizard.");
                                player.won = "no";
                                playerTwo.won = "yes";
                                break;
                            case "scissors":
                                Console.WriteLine("Scissors decapitates lizard.");
                                player.won = "no";
                                playerTwo.won = "yes";
                                break;
                            case "lizard":
                                Console.WriteLine("Lizard clashes with lizard.");
                                player.won = "tie";
                                playerTwo.won = "tie";
                                break;
                            case "spock":
                                Console.WriteLine("Lizard poisons Spock.");
                                player.won = "yes";
                                playerTwo.won = "no";
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
                                player.won = "no";
                                playerTwo.won = "yes";
                                break;
                            case "rock":
                                Console.WriteLine("Spock vaporizes rock.");
                                player.won = "yes";
                                playerTwo.won = "no";
                                break;
                            case "scissors":
                                Console.WriteLine("Spock smashes scissors.");
                                player.won = "yes";
                                playerTwo.won = "no";
                                break;
                            case "lizard":
                                Console.WriteLine("Lizard poisons Spock.");
                                player.won = "no";
                                playerTwo.won = "yes";
                                break;
                            case "spock":
                                Console.WriteLine("Spock clashes with Spock.");
                                player.won = "tie";
                                playerTwo.won = "tie";
                                break;
                        }
                        break;
                    }
            }
            if (player.won == "yes")
            {
                player.score += 1;
            }
            else if (playerTwo.won == "yes")
            {
                playerTwo.score += 1;
            }
            Console.WriteLine("{0} score: {1}. {2} score: {3}", player.name, player.score, playerTwo.name, playerTwo.score);
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
        public void Play()
        {
            player.playAgain = true;
            GetNames();       
            while (player.playAgain)
            {
                Console.WriteLine("Its {0} versus {1}!", player.name, playerTwo.name);
                player.getChoice();
                playerTwo.getChoice();
                compareChoices();
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