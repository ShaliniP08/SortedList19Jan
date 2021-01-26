using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList19Jan
{
    class MethodsOfSortedList
    {
        static void Main(string[] args)
        {
            SortedList st = new SortedList(); //17 methods

            //Add
            st.Add(1, "Sunday");
            st.Add(4, "Wednesday");
            st.Add(5, "Thursday");
            st.Add(2, "Monday");
            st.Add(6, "Friday");
            st.Add(3, "Tuesday");
            st.Add(7, "Saturday");
            foreach (DictionaryEntry de in st)
            {
                Console.WriteLine($"Key is {de.Key} and value is {de.Value}");
            }

            //GetByIndex
            Console.WriteLine($"\nValue at index 2: {st.GetByIndex(2)}");

            //GetKeyList
            Console.WriteLine("\nKeys in the list are");
            IList i1 = st.GetKeyList();
            Console.Write("{");
            foreach (var item in i1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("}");

            //GetValueList
            Console.WriteLine("\nValues in the list are");
            IList i2 = st.GetValueList();
            foreach (var item in i2)
            {
                Console.WriteLine(item);
            }

            //Contains
            Console.WriteLine($"\nIs the key '3' present in the SortedList ? {st.Contains(3)}");

            //ContainsKey
            Console.WriteLine($"\nIs the key '5' present in the SortedList ? {st.ContainsKey(5)}");

            //ContainsValue
            Console.WriteLine($"\nIs the value 'March' present in the SortedList ? {st.ContainsValue("March")}");

            //Capacity
            Console.WriteLine($"\nCapacity of SortedList :  {st.Capacity}");

            //IndexOfKey
            Console.WriteLine($"\nIndexOfKey(6) returns the index of the '6' (Key) : {st.IndexOfKey(6)}");

            //IndexOfValue
            Console.WriteLine($"\nIndexOfValue(\"Monday\") returns the index of the \"Monday\" (Value) : {st.IndexOfValue("Monday")}");

            //Count
            Console.WriteLine($"\nNumber of elements in the Sorted List : {st.Count}");

            //CopyTo
            Console.WriteLine("\nUsing CopyTo method");
            DictionaryEntry[] myArr = new DictionaryEntry[st.Count];
            st.CopyTo(myArr, 0);
            IDictionaryEnumerator copy = st.GetEnumerator();
            while (copy.MoveNext())
            {
                Console.WriteLine(copy.Key + " " + copy.Value);
            }

            //Remove
            st.Remove(3);
            st.Remove(5);
            Console.WriteLine("\nAfter removing 3 and 5 from the Sorted List");
            IDictionaryEnumerator ide = st.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine(ide.Key + " " + ide.Value);
            }

            //RemoveAt
            st.RemoveAt(1);
            Console.WriteLine("\nAfter removing Value at Index '1'");

            //GetEnumerator
            IDictionaryEnumerator ide1 = st.GetEnumerator();
            while(ide1.MoveNext())
            {
                Console.WriteLine(ide1.Key + " " + ide1.Value);
            }

            //Clone
            Console.WriteLine("\nUsing Clone method");
            SortedList clone = st.Clone() as SortedList;
            IDictionaryEnumerator cloning = st.GetEnumerator();
            while (cloning.MoveNext())
            {
                Console.WriteLine(cloning.Key + " " + cloning.Value);
            }

            //Clear
            st.Clear();
            Console.WriteLine("\nAfter using clear method");
            IDictionaryEnumerator cl = st.GetEnumerator();
            while (cl.MoveNext())
            {
                Console.WriteLine(cl.Key + " " + cl.Value);
            }

            Console.ReadLine();
        }
    }
}


