using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_To_Use_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //A variable is a representation of information, so when you write a programe I would need to store information somewhere so I can access that information and do something with it.
            //In C# variables have types.

            int countOfBooks = 1;
            string myName = "George"; //string is a series of characters
            bool IsCompatible = true; //Bolean can only be true or false
            string number = "2";
            int numberconverted = Convert.ToInt32(number);

            Console.WriteLine(countOfBooks);
            Console.WriteLine(myName);
            Console.WriteLine(IsCompatible);
            Console.WriteLine(number);
            Console.WriteLine(numberconverted);
        }
    }
}
