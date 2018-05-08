using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Person
    {
        private string _firstname;
        private string _middlename;
        private string _lastname;
        private int _age = 21;
        public Person(string firstname, string middlename, string lastname)
        {
            _firstname = firstname;
            _middlename = middlename;
            _lastname = lastname;
        }
        public Person(string firstname, string middlename, string lastname, int age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _middlename = middlename;
            _age = age;
        }
        public string GetFullname()
        {
            return $"{_firstname} {_lastname}";
        }
        public string GetFullnameWithAge(int age)
        {
            return $"{_firstname} {_lastname} {age}";
        }
    }
}
