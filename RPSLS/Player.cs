using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string name;
        public string[] options = new string[5] { "Rock", "Paper", "Scissors", "Lizzard", "Spock" };
        public int wins = 0;
        public abstract string ChooseGesture();
    }
}
