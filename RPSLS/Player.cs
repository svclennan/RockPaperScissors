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
        public string[] options = new string[5] { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public int wins;
        public abstract string ChooseGesture();
    }
}
