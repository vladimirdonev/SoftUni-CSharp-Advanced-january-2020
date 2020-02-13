using System;
using System.Collections.Generic;

namespace ListyIteratorr
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = null;
            var Listyiterator = new ListyIterator<string>(new List<string>());
            while (command != "END ")
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(" ");
                if(command == "END")
                {
                    break;
                }
                switch (splitedinput[0])
                {
                    case "Create":
                        if (splitedinput.Length > 1)
                        {
                            var list = new List<string>();
                            for (int i = 1; i < splitedinput.Length; i++)
                            {
                                list.Add(splitedinput[i]);
                            }
                            Listyiterator = new ListyIterator<string>(list);
                        }
                        else
                        {
                            
                        }
                        break;
                    case "Move":
                        Console.WriteLine(Listyiterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            Listyiterator.Print();
                        }
                        catch(Exception error)
                        {
                            Console.WriteLine(error);
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(Listyiterator.HasNext());
                        break;
                    case "END":
                        break;
                    case "PrintAll":
                        Listyiterator.PrintAll();
                        break;
                }
            }
        }
    }
}
