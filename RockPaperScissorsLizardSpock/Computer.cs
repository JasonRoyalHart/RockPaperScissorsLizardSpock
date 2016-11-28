using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        public override void getChoice()
        {
            Random computerSelector = new Random();
            int computerChoice = computerSelector.Next(0, 5);
            switch (computerChoice)
            {
                case 0:
                    choice = "rock";
                    break;
                case 1:
                    choice = "paper";
                    break;
                case 2:
                    choice = "scissors";
                    break;
                case 3:
                    choice = "lizard";
                    break;
                case 4:
                    choice = "spock";
                    break;
                default:
                    choice = "default";
                    Console.WriteLine("Warning, reached default value!");
                    break;
            }
            Console.WriteLine("{0} chooses {1}.", name, choice);

        }
    }
}
