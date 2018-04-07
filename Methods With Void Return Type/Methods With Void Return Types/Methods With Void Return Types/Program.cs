using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_With_Void_Return_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.GetFullName("George", "Dennis");
        }
    }
}
