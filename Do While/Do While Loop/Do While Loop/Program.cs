using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            do
            {
                input = Console.ReadLine();
                Console.WriteLine("Your input is {0}.", input);
            }
            while (!input.Equals(string.Empty));
            {

            }
        }
    }
}
