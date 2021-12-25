using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        List<Person> persons;

        public Family()
        {
            this.persons = new List<Person>();
        }

        public void AddMember(Person member)
        {
            persons.Add(member);
        }
        
        public Person GetOldestMember()
        {
            return persons.OrderByDescending(x => x.Age).First();
        }
    }
}
