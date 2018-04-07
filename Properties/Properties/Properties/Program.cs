using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Lives = 100;
            Console.WriteLine(player.Lives);
        }
    }
}
