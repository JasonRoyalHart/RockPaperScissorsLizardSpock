using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
        public string won;
        public bool playAgain;
        public string choice;
        public string name;
        public int score;

        public Player()
        {
            name = "The Computer";
            score = 0;
        }
        public virtual void getChoice()
        {

        }

        public void AdjustScore(int adjust)
        {
            score += adjust;
        }


        
    }

}
