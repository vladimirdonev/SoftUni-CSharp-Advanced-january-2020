using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] NameandAge = Console.ReadLine().Split(" ");
                string Name = NameandAge[0];
                int Age = int.Parse(NameandAge[1]);
                Person person = new Person(Age,Name);
                family.AddMember(person);
            }
            Console.WriteLine(family.GetOldestMember());
        }
    }
}
