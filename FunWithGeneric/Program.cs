using System;
using System.Collections.Generic;

namespace FunWithGeneric
{
    class Program
    {
        static void Main (string[] args)
        {
            UseGenericList();
        }

        static void UseGenericList ()
        {
            List<Person> people = new List<Person> ()
            {

                new Person {FirstName = "Serj", LastName = "Ivanov", Age = 40},
                new Person {FirstName = "Anna", LastName = "Ivanova", Age = 38},
                new Person {FirstName = "Viktor", LastName = "Ivanov", Age = 7},
                new Person {FirstName = "Maria", LastName = "Ivanova", Age = 2}
            };

            foreach (Person person in people)
                Console.WriteLine(person);

            people.Insert(2, new Person {FirstName = "Julia", LastName = "Ivanova", Age = 9});
            
            Person[] peopleArray = people.ToArray();
            foreach (Person person in peopleArray)
                Console.WriteLine($"First name: {person.FirstName}");
        }
    }
}