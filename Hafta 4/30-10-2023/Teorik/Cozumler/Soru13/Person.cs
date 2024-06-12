using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru13
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public GenderType Gender;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }


}
