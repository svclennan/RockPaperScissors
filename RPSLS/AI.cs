using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        public AI(string name)
        {
            this.name = name;
            wins = 0;
        }
        public override string ChooseGesture()
        {
            Random rand = new Random();
            int choice = rand.Next(5);
            return options[choice];
        }
    }
}
