using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("George", "Dennis");
            Person person2 = new Person("George", "Alexander", 21);

            Console.WriteLine(person1.GetFullname());
            Console.WriteLine(person1.GetFullnameWithAge(21));
            Console.WriteLine(person2.GetFullnameWithAge(21));
        }
    }
}