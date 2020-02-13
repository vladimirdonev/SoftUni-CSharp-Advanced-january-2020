using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        List<Person> people = new List<Person>();
        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
        {
            int maxage = people.Max(x => x.Age);
            people = people.Where(x => x.Age == maxage).ToList();
            return this.people.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
