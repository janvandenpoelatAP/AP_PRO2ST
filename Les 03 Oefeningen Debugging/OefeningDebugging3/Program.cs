using System;
using System.Collections.Generic;

namespace OefeningDebugging3
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person> { new Person { Name = "Jan" }, new Person { Name = "Dimitri" } };
            foreach(var person in persons)
            {
                Console.WriteLine(persons);
            }
            Console.ReadLine();
        }
    }
}
