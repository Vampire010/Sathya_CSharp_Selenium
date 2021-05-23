using System;
using System.Collections.Generic;

namespace Demo_Project1.Collections_List
{
    public class List_ex1
    {
        static void Mains(string[] args)
        {
            List<int> primeNumbers = new List<int>();

            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            foreach (int primenums in primeNumbers)
            {
                Console.WriteLine(primenums);
            }


                        var bigCities = new List<string>()
                                                    {
                                                    "New York",
                                                    "London",
                                                    "Mumbai",
                                                    "Chicago"

                                                    };

            foreach (string bigCities_names in bigCities)
            {
                Console.WriteLine(bigCities_names);
            }
        }
    }
}
