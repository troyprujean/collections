using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArraysAdvanced
{
    class Person
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int TicketAmount { get; set; }

        public Person(string _fName, string _lName, int _age)
        {
            FirstName = _fName;
            LastName = _lName;
            Age = _age;
        }
    }
}
