using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshmboApp
{
    class RoshamboApp
    {
        public RoshamboApp()
        {
            PlayerWins = 0;
            CompWins = 0;
            Round = 0;
        }

        public int PlayerWins { get; set; }
        public int CompWins { get; set; }
        public int Round { get; set; }



        public static ComputerPlayer InitiateGame()
        {
            
            Console.WriteLine("Would you like to face Rick(1) or Bob (2)");
            int picker = Validator.GetIntChoice(1, 2);
            if (picker == 0)
            {
                ComputerPlayer comp = new ComputerPlayer("Rick", true);
                return comp;
            }
            else
            {
                ComputerPlayer comp = new ComputerPlayer("Bob", false);
                return comp;
            }
            
        }
        
            
    }
}
