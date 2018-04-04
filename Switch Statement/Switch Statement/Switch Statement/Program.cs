using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "George":
                    Console.WriteLine("This is my name.");
                    break;
                case "C#":
                    Console.WriteLine("This is what i'm learning.");
                    break;
                default:
                    Console.WriteLine("There was no match.");
                    break;

            }
        }
    }
}
