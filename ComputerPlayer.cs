using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshmboApp
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string name, bool random = true)
            : base (name)
        {
            Random = random;
        }

        public bool Random { get; set; }

        public override Roshambo GenerateRoshambo()
        {
            if (Random)
            {
                Random rnd = new Random();
               double die = rnd.NextDouble();
                die = (int)(die * 3);
               if(0 == die)
                {
                    return Roshambo.Rock;
                }
               else if (1==die)
                {
                    return Roshambo.Paper;
                }
               else
                {
                    return Roshambo.Scissors;
                }
            }
            else
            {
                return Choice;
            }
        }
    }
}
