using System;
namespace Demo_Project1.Arrays_Example
{
    public class Array_Methods_Ex
    {
        static void Mains(string[] args)
        {
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };
            Console.WriteLine("*******Sort********");

            Array.Sort(nums); // sorts array
            foreach (int num in nums)
            {

                Console.WriteLine(num);

            }

            Console.WriteLine("*******Reverse********");

            Array.Reverse(nums); // sorts array in descending order
            foreach (int num in nums)
            {


                Console.WriteLine(num);

            }


            Console.WriteLine("******* iterates array********");

            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array


            Console.WriteLine("******* binary search *********");

            Array.BinarySearch(nums, 500);
            // return -1 if true , else return -6
            Console.WriteLine(Array.BinarySearch(nums, 5199)); 




        }
    }
}
