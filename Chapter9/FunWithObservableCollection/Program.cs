using System;
using System.Collections.ObjectModel;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person {FirstName = "Serj", LastName = "Ivanov", Age = 40},
                new Person {FirstName = "Anna", LastName = "Ivanova", Age = 38},
                new Person {FirstName = "Viktor", LastName = "Ivanov", Age = 7},
                new Person {FirstName = "Maria", LastName = "Ivanova", Age = 2}
            };

            people.CollectionChanged += people_CollectionChanged;
        }

        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
