using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RPSLS
{
    class Game
    {
        Player p1;
        Player p2;
        int firstTo = 3;
        public Game(string name)
        {
            p1 = new Human(name);
        }

        public void StartGame()
        {
            ChooseOpponent();
            while (p1.wins < firstTo && p2.wins < firstTo)
            {
                RunRound();
            }
            if (p1.wins == firstTo)
            {
                Console.WriteLine($"{p1.name} wins!");
            }
            if (p2.wins == firstTo)
            {
                Console.WriteLine($"{p2.name} wins!");
            }
            Console.WriteLine("Would you like to play again? y/n");
            string again = Console.ReadLine();
            if (again == "y")
            {
                p1.wins = 0;
                p2.wins = 0;
                StartGame();
            }
        }
        public void ChooseOpponent()
        {
            Console.WriteLine("Would you like to play against\n1)AI\n2)Human");
            string input = Console.ReadLine();
            bool valid = false;
            while (!valid)
            {
                switch (input)
                {
                    case "1":
                        {
                            p2 = new AI("Siri");
                            valid = true;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("What is your name?");
                            p2 = new Human(Console.ReadLine());
                            valid = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input. Try again.");
                            input = Console.ReadLine();
                            break;
                        }
                }
            }
        }
        public void RunRound()
        {
            string p1Choice = p1.ChooseGesture();
            Console.Clear();
            string p2Choice = p2.ChooseGesture();
            Console.Clear();
            if (p1Choice == "Rock")
            {
                if (p2Choice == "Rock")
                {
                    Tie();
                }
                if (p2Choice == "Paper")
                {
                    Console.WriteLine("Paper covers Rock");
                    P2Win();
                }
                if (p2Choice == "Scissors")
                {
                    Console.WriteLine("Rock crushes Scissors.");
                    P1Win();
                }
                if (p2Choice == "Lizard")
                {
                    Console.WriteLine("Rock crushes Lizard");
                    P1Win();
                }
                if (p2Choice == "Spock")
                {
                    Console.WriteLine("Spock vaporizes Rock");
                    P2Win();
                }
            }
            else if (p1Choice == "Paper")
            {
                if (p2Choice == "Rock")
                {
                    Console.WriteLine("Paper covers Rock");
                    P1Win();
                }
                if (p2Choice == "Paper")
                {
                    Tie();
                }
                if (p2Choice == "Scissors")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    P2Win();
                }
                if (p2Choice == "Lizard")
                {
                    Console.WriteLine("Lizard eats Paper");
                    P2Win();
                }
                if (p2Choice == "Spock")
                {
                    Console.WriteLine("Paper disproves Spock");
                    P1Win();
                }
            }
            else if (p1Choice == "Scissors")
            {
                if (p2Choice == "Rock")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    P2Win();
                }
                if (p2Choice == "Paper")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    P1Win();
                }
                if (p2Choice == "Scissors")
                {
                    Tie();
                }
                if (p2Choice == "Lizard")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    P1Win();
                }
                if (p2Choice == "Spock")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    P2Win();
                }
            }
            else if (p1Choice == "Lizard")
            {
                if (p2Choice == "Rock")
                {
                    Console.WriteLine("Rock crushes Lizard");
                    P2Win();
                }
                if (p2Choice == "Paper")
                {
                    Console.WriteLine("Lizard eats Paper");
                    P1Win();
                }
                if (p2Choice == "Scissors")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    P2Win();
                }
                if (p2Choice == "Lizard")
                {
                    Tie();
                }
                if (p2Choice == "Spock")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    P1Win();
                }
            }
            else if (p1Choice == "Spock")
            {
                if (p2Choice == "Rock")
                {
                    Console.WriteLine("Spock vaporizes Rock");
                    P1Win();
                }
                if (p2Choice == "Paper")
                {
                    Console.WriteLine("Paper disproves Spock");
                    P2Win();
                }
                if (p2Choice == "Scissors")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    P1Win();
                }
                if (p2Choice == "Lizard")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    P2Win();
                }
                if (p2Choice == "Spock")
                {
                    Tie();
                }
            }
        }
        public void P1Win()
        {
            Console.WriteLine($"{p1.name} beat {p2.name}");
            p1.wins++;
            Console.WriteLine($"{p1.name} has {p1.wins} wins");
            Console.WriteLine($"{p1.name} {p1.wins} - {p2.wins} {p2.name}");
            Console.ReadLine();
            Console.Clear();

        }
        public void P2Win()
        {
            Console.WriteLine($"{p2.name} beat {p1.name}");
            p2.wins++;
            Console.WriteLine($"{p2.name} has {p2.wins} wins");
            Console.WriteLine($"{p1.name} {p1.wins} - {p2.wins} {p2.name}");
            Console.ReadLine();
            Console.Clear();
        }
        public void Tie()
        {
            Console.WriteLine($"{p1.name} tied {p2.name}");
            Console.WriteLine($"{p1.name} {p1.wins} - {p2.wins} {p2.name}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
