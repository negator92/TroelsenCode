using System;
using System.Collections.Generic;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Indexers ***\n");

            PersonCollection people = new PersonCollection();

            people[0] = new Person("Homer", "Simpson ", 40);
            people[1] = new Person("Marge", "Simpson ", 38);
            people[2] = new Person("Lisa", "Simpson", 9);
            people[3] = new Person("Bart", "Simpson", 7);
            people[4] = new Person("Maggie", "Simpson", 2);

            for (int person = 0; person < people.Count; person++)
            {
                Console.Write($"Person №{person}\t");
                Console.Write($"Name: {people[person].FirstName} {people[person].LastName}\t");
                Console.Write($"Age: {people[person].Age}\n");
            }

            UseGenericListPeople();
        }

        private static void UseGenericListPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Mary", "Smith", 20));
            people.Add(new Person("James", "Smith", 22));

            people[0] = new Person("Alex", "Black", 23);

            for (int person = 0; person < people.Count; person++)
            {
                Console.Write($"Person №{person}\t");
                Console.Write($"Name: {people[person].FirstName} {people[person].LastName}\t");
                Console.Write($"Age: {people[person].Age}\n");
            }
        }
    }
}