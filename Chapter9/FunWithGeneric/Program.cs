using System;
using System.Collections.Generic;

namespace FunWithGeneric
{
    class Program
    {
        static void Main (string[] args)
        {
            UseGenericList();
            UseGenericStack();
            UseGenericQueue();
            UseSortedSet();
            UseDictionary();
        }

        private static void UseDictionary()
        {
            Dictionary<string, Person> peopleDictionary = new Dictionary<string, Person>();
            peopleDictionary.Add("Serj", new Person {FirstName = "Serj", LastName = "Ivanov", Age = 40});
            peopleDictionary.Add("Anna", new Person {FirstName = "Anna", LastName = "Ivanova", Age = 38});
            peopleDictionary.Add("Victor", new Person {FirstName = "Victor", LastName = "Ivanov", Age = 7});
            Person serj = peopleDictionary["Serj"];
            Console.WriteLine(serj);
        }

        static void UseSortedSet()
        {
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName = "Serj", LastName = "Ivanov", Age = 40},
                new Person {FirstName = "Anna", LastName = "Ivanova", Age = 38},
                new Person {FirstName = "Viktor", LastName = "Ivanov", Age = 7},
                new Person {FirstName = "Maria", LastName = "Ivanova", Age = 2}
            };

            foreach (Person person in peopleSortedSet)
                Console.WriteLine(person);
            Console.WriteLine();

            peopleSortedSet.Add(new Person { FirstName = "Pablo", LastName = "Fellini", Age = 23 });
            peopleSortedSet.Add(new Person { FirstName = "Antonio", LastName = "Fellini", Age = 32 });

            foreach (Person person in peopleSortedSet)
                Console.WriteLine(person);
        }

        static void UseGenericQueue()
        {
            Queue<Person> peopleQueue = new Queue<Person>();
            peopleQueue.Enqueue(new Person {FirstName = "Serj", LastName = "Ivanov", Age = 40});
            peopleQueue.Enqueue(new Person {FirstName = "Anna", LastName = "Ivanova", Age = 38});
            peopleQueue.Enqueue(new Person {FirstName = "Viktor", LastName = "Ivanov", Age = 7});
            Console.WriteLine($"{peopleQueue.Peek().FirstName} is first in line!");
            GetCoffee(peopleQueue.Dequeue());
            GetCoffee(peopleQueue.Dequeue());
            GetCoffee(peopleQueue.Dequeue());
            try
            {
                GetCoffee(peopleQueue.Dequeue());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\nError! {ex.Message}");
            }
        }

        static void GetCoffee(Person person)
            => Console.WriteLine($"{person.FirstName} got coffee!");

        static void UseGenericStack()
        {
            Stack<Person> peopleStack = new Stack<Person>();
            peopleStack.Push(new Person {FirstName = "Serj", LastName = "Ivanov", Age = 40});
            peopleStack.Push(new Person {FirstName = "Anna", LastName = "Ivanova", Age = 38});
            peopleStack.Push(new Person {FirstName = "Viktor", LastName = "Ivanov", Age = 7});

            Console.WriteLine($"First person is: {peopleStack.Peek()}");
            Console.WriteLine($"Popped off {peopleStack.Pop()}");

            Console.WriteLine($"First person is: {peopleStack.Peek()}");
            Console.WriteLine($"Popped off {peopleStack.Pop()}");

            Console.WriteLine($"First person is: {peopleStack.Peek()}");
            Console.WriteLine($"Popped off {peopleStack.Pop()}");

            try
            {
                Console.WriteLine($"\nFirst person is: {peopleStack.Peek()}");
                Console.WriteLine($"Popped off {peopleStack.Pop()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\nError! {ex.Message}");
            }
        }

        static void UseGenericList ()
        {
            List<Person> peopleList = new List<Person> ()
            {
                new Person {FirstName = "Serj", LastName = "Ivanov", Age = 40},
                new Person {FirstName = "Anna", LastName = "Ivanova", Age = 38},
                new Person {FirstName = "Viktor", LastName = "Ivanov", Age = 7},
                new Person {FirstName = "Maria", LastName = "Ivanova", Age = 2}
            };

            foreach (Person person in peopleList)
                Console.WriteLine(person);

            peopleList.Insert(2, new Person {FirstName = "Julia", LastName = "Ivanova", Age = 9});
            
            Person[] peopleArray = peopleList.ToArray();
            foreach (Person person in peopleArray)
                Console.WriteLine($"First name: {person.FirstName}");
        }
    }
}