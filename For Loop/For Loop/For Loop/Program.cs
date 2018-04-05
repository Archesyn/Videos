using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{//A for loop is meant to be looped a set amount of times
    class Program
    {
        static void Main(string[] args)
        {//The first part of the for loop is declaring a variable "int i = 0;".
            //The second part is the condition "i < 10".
            //The third part is the increment "i++".
            //"Break;" is a branching statement which exits the block of code and onto the next.
            //The "continue;" statement passes control to the next iteration. 
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) continue;
                Console.WriteLine("The i is {0}", i);

            }
        }
    }
}
