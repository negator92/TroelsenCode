using System;
using System.Collections;

namespace IssuesWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SimpleBoxUnboxOperation();
            WorkWithArrayList();
            ArrayListOfRandomObjects();
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