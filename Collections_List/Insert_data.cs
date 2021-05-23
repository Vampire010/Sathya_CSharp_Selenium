using System;
using System.Collections.Generic;

namespace Demo_Project1.Collections_List
{
    public class Insert_data
    {
        static void Mains(string[] args)
        {
            var numbers = new List<int>() { 20, 10, 40, 30 };


            numbers.Sort();// inserts 11 at 1st index: after 10.
            Console.WriteLine("   ");

            Console.WriteLine("**********Sorted Elemnts are********* ");

            foreach (var num in numbers)
                Console.Write(" , " + num);


            numbers.Insert(0, 11);// inserts 11 at 1st index: after 10.
            Console.WriteLine("   ");

            Console.WriteLine("**********Before Remove********* ");

            foreach (var num in numbers)
                Console.Write( " , "+ num) ;


            numbers.RemoveAt(4);
            Console.WriteLine("   ");

            Console.WriteLine("*********After Remove*******");

            foreach (var num in numbers)
                Console.Write(" , " + num);

            numbers.Remove(11);
            Console.WriteLine("   ");
            Console.WriteLine("********* Specfied value Removed*******");

            foreach (var num in numbers)
                Console.Write(" , " + num);

            numbers.RemoveRange(0, 1);
            Console.WriteLine("   ");
            Console.WriteLine("********* Specfied value Removed*******");

            foreach (var num in numbers)
                Console.Write(" , " + num);
                

        }
    }
}
