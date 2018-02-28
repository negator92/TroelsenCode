using System;
using System.Collections;

namespace IssuesWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxUnboxOperation();
            WorkWithArrayList();
            ArrayListOfRandomObjects();
            UsePersonCollection();
        }

        static void UsePersonCollection()
        {
            Console.WriteLine("Custom Person Collection\n");
            
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Serj", "Ivanov", 40));
            myPeople.AddPerson(new Person("Anna", "Ivanova", 38));
            myPeople.AddPerson(new Person("Julia", "Ivanova", 9));
            myPeople.AddPerson(new Person("Viktor", "Ivanov", 7));
            myPeople.AddPerson(new Person("Maria", "Ivanova", 2));
            
            foreach (Person person in myPeople)
            {
                Console.WriteLine(person);
            }
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;
            object boxedInt = myInt;
            int unboxedInt = (int) boxedInt;
        }
        
        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
        }

        static void ArrayListOfRandomObjects()
        {
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.Unix, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }
    }
}