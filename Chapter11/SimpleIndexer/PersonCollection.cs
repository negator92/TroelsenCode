using System.Collections;

namespace SimpleIndexer
{
    public class PersonCollection : IEnumerable
    {
        private ArrayList arrayListPeople = new ArrayList();

        public Person this[int index]
        {
            get => (Person)arrayListPeople[index];
            set => arrayListPeople.Insert(index, value);
        }

        public Person GetPerson(int position)
            => (Person)arrayListPeople[position];

        public void AddPerson(Person person)
        {
            arrayListPeople.Add(person);
        }

        public void ClearPeople()
        {
            arrayListPeople.Clear();
        }

        public int Count { get => arrayListPeople.Count; }

        // IEnumerator IEnumerable.GetEnumerator()
        IEnumerator IEnumerable.GetEnumerator()
            => arrayListPeople.GetEnumerator();
    }
}