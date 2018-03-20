using System.Collections.Generic;

namespace FunWithGeneric
{
    public class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            if (firstPerson.Age > secondPerson.Age)
                return 1;
            else if (firstPerson.Age < secondPerson.Age)
                return -1;
            else
                return 0;
        }
    }
}
