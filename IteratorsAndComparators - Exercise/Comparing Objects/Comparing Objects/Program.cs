using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            var command = string.Empty;
            var Persons = new List<Person>();
            while(command != "END")
            {
                command = Console.ReadLine();
                if(command == "END")
                {
                    break;
                }
                else
                {
                    string[] splitedinput = command.Split(" ");
                    var person = new Person(splitedinput[0], int.Parse(splitedinput[1]), splitedinput[2]);
                    Persons.Add(person);
                }
            }
        }
    }
}
