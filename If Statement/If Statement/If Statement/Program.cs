using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ControlFlowDecision
namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
           string player =  Console.ReadLine();

            if(player.Equals("AI"))
            {
                Console.WriteLine("The player is AI.");
            }
            else if (player.Equals("Human"))
            {
                Console.WriteLine("The player is Human.");
            }
            else
            {
                Console.WriteLine("The player is not AI and not Human");
            }
        }
    }
}
