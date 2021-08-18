using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> newDict = new Dictionary<int, string>();


            newDict.Add(1, "Zebra");
            newDict.Add(2, "Tiger");
            newDict.Add(3, "Elephant");
            newDict.Add(4, "Pig");
            newDict.Add(5, "Shark");

            Console.WriteLine("There are " + newDict.Keys.Count + " Animals in the dictionary");
            foreach(var i in newDict)
            {
                Console.WriteLine(i.Value);
            }

            Console.WriteLine("The animal in the 3rd pen is a " + newDict[3] + ".");
            int findKey = newDict.FirstOrDefault(x => x.Value == "Shark").Key;
            Console.WriteLine("The Shark is in the " + findKey + "th pen.");

        }
    }
}
