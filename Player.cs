using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshmboApp
{
    public abstract class Player
    {
        protected Player(string name)
        {
            this.Choice = Roshambo.Rock;
            Name = name;
        }

        public Roshambo Choice { get; set; }
        public string Name { get; set; }


        public abstract Roshambo GenerateRoshambo();
    }
}
