using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                string name = info[0];
                int age = int.Parse(info[1]);
                persons.Add(new Person(name, age));
            }

            persons = persons.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
