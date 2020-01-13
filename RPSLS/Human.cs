using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
        }
        public override string ChooseGesture()
        {
            int count = 1;
            Console.WriteLine("Please choose a gesture.");
            foreach (string choice in options)
            {
                Console.WriteLine(count + ")" + choice);
                count++;
            }
            int output = Convert.ToInt32(Console.ReadLine());
            switch (output)
            {
                case 1:
                    {
                        return options[0];
                    }
                case 2:
                    {
                        return options[1];
                    }
                case 3:
                    {
                        return options[2];
                    }
                case 4:
                    {
                        return options[3];
                    }
                case 5:
                    {
                        return options[4];
                    }
            }
            return "Rock";
        }
    }
}
