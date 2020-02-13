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
        public void GetOldestMembers()
        {
            int maxage = people.Max(x => x.Age);
            people = people.Where(x => x.Age > 30).OrderBy(y => y.Name).ToList();
            foreach (var name in people)
            {
                Console.WriteLine($"{name.Name} - {name.Age}");
            }
        }
    }
}
