using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshmboApp
{
    public class Program
    {
        
        static void Main(string[] args)
        {
           
            
            string name = Validator.GetValidString("What is your Name?");
            HumanPlayer nameUser = new HumanPlayer(name);

            RoshamboApp scenario = new RoshamboApp();
            ComputerPlayer comp = RoshamboApp.InitiateGame();

            Roshambo compCh;
            Roshambo userCh;
            bool repeat = true;
            while(repeat)
            {
                Console.Clear();
                userCh = nameUser.GenerateRoshambo();
                compCh= comp.GenerateRoshambo();

                Console.Clear();
                Console.WriteLine($"\n{comp.Name}: {compCh}");
                Console.WriteLine($"{nameUser.Name}: {userCh}");

                if ((int)userCh == (int)compCh+1 || ((int)userCh == 0 && (int)compCh == 3))
                {
                    Console.WriteLine($"{nameUser.Name} wins round.");
                    scenario.PlayerWins++;
                }
                else if ((int)userCh+1 == (int)compCh || ((int)userCh == 3 && (int)compCh == 0))
                {
                    Console.WriteLine($"{comp.Name} wins round.");
                    scenario.CompWins++;
                }
                else
                {
                    Console.WriteLine("Draw.");
                }

                scenario.Round++;
                Console.WriteLine($"\n{scenario.Round}= {nameUser.Name}:{scenario.PlayerWins} - {comp.Name}:{scenario.CompWins}");
                repeat = Validator.GetYN("Another round?");
            }

            Console.Clear();
            if (scenario.PlayerWins > scenario.CompWins)
            {
                Validator.EndProgram($"{nameUser.Name} WINS at round {scenario.Round}!");
            }
            else
            {
                Validator.EndProgram($"{comp.Name} WINS at round {scenario.Round}!");
            }
            
        }
        
    }
}
