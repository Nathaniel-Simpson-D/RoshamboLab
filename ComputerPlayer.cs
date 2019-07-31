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
               
                Roshambo RPS;
                Enum.TryParse<Roshambo>($"{die}", out RPS);
                return RPS;
            }
            else
            {
                return Choice;
            }
        }
    }
}
