using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshmboApp
{
    class HumanPlayer :Player
    {
        public HumanPlayer(string name)
            : base(name)
        {
            this.Choice = Roshambo.Rock;
         
        }

        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Choose: Rock, Papaer, or Scissors.");
            int input = Validator.GetRPSChoice();
            if (input == 0)
            {
                this.Choice = Roshambo.Rock;
                return Roshambo.Rock;
            }
            else if (input == 1)
            {
                this.Choice = Roshambo.Paper;
                return Roshambo.Paper;
            }
            else
            {
                this.Choice = Roshambo.Scissors;
                return Roshambo.Scissors;
            }
        }
    }
}
