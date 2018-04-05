using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrameBasics
{
    public class Person
    {
        public string FirstName { set; get; }
        public string Lastname { set; get; }

        public void GetFullName()
        {
            Console.WriteLine("Get my fullname {0} {1}.", FirstName, Lastname);
        }

        public void Walk()
        {
            Console.WriteLine("I am walking.");
        }

        public void Talk()
        {
            Console.WriteLine("I am talking.");
        }

        public void Eat()
        {
            Console.WriteLine("I am eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping.");
        }
    }
}
