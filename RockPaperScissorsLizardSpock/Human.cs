using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        public override void getChoice()
        {
            Console.WriteLine("{0}, please choose rock, paper, scissors, lizard, or spock", name);
            bool chosen = false;
            while (!chosen)
            {
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "rock":
                    case "paper":
                    case "scissors":
                    case "lizard":
                    case "spock":
                        chosen = true;
                        Console.WriteLine("You chose {0}.", choice);
                        break;
                    default:
                        Console.WriteLine("{0}, please choose rock, paper, scissors, lizard, or spock.", name);
                        break;
                }
            }
        }
    }
}
