using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_With_Void_Return_Types
{
    class Person
    {
        public void GetFullName (string Firstname, string Lastname)
        {
            Console.WriteLine($"The fullname of the person is {Firstname} {Lastname}");
        }
    }
}
