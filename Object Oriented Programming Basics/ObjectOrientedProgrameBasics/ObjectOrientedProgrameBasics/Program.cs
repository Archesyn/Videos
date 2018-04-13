using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrameBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.FirstName = "George";
            me.Lastname = "Dennis";

            me.GetFullName();

            me.Walk();
            me.Eat();
            me.Talk();
            me.Sleep();

            SuperPerson superPerson = new SuperPerson();
            superPerson.FirstName = "Super";
            superPerson.Lastname = "Dude";
            superPerson.GetFullName();

            superPerson.Walk();
            superPerson.Eat();
            superPerson.Talk();
            superPerson.Sleep();
            superPerson.Fly();
   
        }
    }
}
