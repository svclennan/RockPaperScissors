using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name1 = Console.ReadLine();

            Game start = new Game(name1);
            start.StartGame();
            Console.ReadLine();
        }
    }
}
