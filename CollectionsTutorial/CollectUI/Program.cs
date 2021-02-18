using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace CollectUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList code

            //ArrayLists
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            //Print length of array list
            Console.WriteLine("Count {0}", aList.Count);
            Console.WriteLine("Count {0}", aList.Capacity);

            //Add a range to ArrayList
            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] {"C#", "Java", "VB.NET"});

            //Sort ArrayList (if same data type)
            aList2.Sort();
            //Reverse the ArrayList
            aList2.Reverse();

            //Traverse Through ArrayList
            foreach(object o in aList2)
            {
                Console.WriteLine(o);
            }

            #endregion

        }
    }
}
