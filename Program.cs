using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();

            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("elderberry");

            Console.WriteLine("Total no. of elements in the ArrayList:"+fruits.Count);
            PrintElements(fruits);
            bool containsDate = SearchItem(fruits, "date");
            Console.WriteLine("Does the ArrayList contain 'date'?"+containsDate);
            InsertItem(fruits, 1, "g");
            RemoveItem(fruits, "banana");
            Console.WriteLine("Elements in the ArrayList after modification:");
            PrintElements(fruits);
            Console.ReadKey();
        }


        static void PrintElements(ArrayList list)
        {
            Console.WriteLine("Elements in the ArrayList:");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static bool SearchItem(ArrayList list, string item)
        {
            return list.Contains(item);
        }

        static void InsertItem(ArrayList list,int index, object item)
        {
            list.Insert(index, item);
        }

        static void RemoveItem(ArrayList list, object item)
        {
            list.Remove(item);
        }

    }

}
