using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player p1;
        Player p2;
        public Game(string name)
        {
            p1 = new Human(name);
            StartGame();
        }

        public void StartGame()
        {
            Console.WriteLine("Would you like to play against\n1)AI\n2)Human");
            int input = Convert.ToInt32(Console.ReadLine());
            bool valid = false;
            while (!valid)
            {
                switch (input)
                {
                    case 1:
                        {
                            p2 = new AI("Siri");
                            valid = true;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("What is your name?");
                            p2 = new Human(Console.ReadLine());
                            valid = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input. Try again.");
                            input = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                }
            }
        }
    }
}
