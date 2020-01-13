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
            string output;
            string gesture = "Rock";
            Console.WriteLine(name + ", Please choose a gesture.");
            foreach (string choice in options)
            {
                Console.WriteLine(count + ")" + choice);
                count++;
            }
            bool valid = false;
            while (!valid)
            {
                output = Console.ReadLine();
                switch (output)
                {
                    case "1":
                        {
                            gesture = options[0];
                            valid = true;
                            break;
                        }
                    case "2":
                        {
                            gesture = options[1];
                            valid = true;
                            break;
                        }
                    case "3":
                        {
                            gesture = options[2];
                            valid = true;
                            break;
                        }
                    case "4":
                        {
                            gesture = options[3];
                            valid = true;
                            break;
                        }
                    case "5":
                        {
                            gesture = options[4];
                            valid = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not a valid input. Try again.");
                            break;
                        }
                }
            }
            return gesture;
        }
    }
}
