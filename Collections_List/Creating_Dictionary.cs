using System;
using System.Collections.Generic;

namespace Demo_Project1.Collections_List
{
    public class Creating_Dictionary
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(2, "Two");
            numberNames.Add(1, "One"); //adding a key/value using the Add() method

            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three");
            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
