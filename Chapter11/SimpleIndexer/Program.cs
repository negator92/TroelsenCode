using System;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Indexers ***\n");

            PersonCollection people = new PersonCollection();

            people[0] = new Person("Homer", "Simpson ", 40);
            people[1] = new Person("Marge ", "Simpson ", 38);
            people[2] = new Person(" Lisa ", " S impson", 9);
            people[3] = new Person("Bart ", " Simpson", 7);
            people[4] = new Person("Maggie ", "Simpson", 2);

            for (int person = 0; person < people.Count; person++)
            {
                Console.WriteLine($"Person №{person}");
                Console.WriteLine($"Name: {people[person].FirstName} {people[person].LastName}");
                Console.WriteLine($"Age: {people[person].Age}");
            }
        }
    }
}