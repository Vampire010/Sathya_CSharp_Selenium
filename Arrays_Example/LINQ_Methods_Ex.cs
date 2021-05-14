
using System;
using System.Linq;

namespace Demo_Project1.Arrays_Example
{
    public class LINQ_Methods_Ex
    {
        static void Mains(string[] args)
        {
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };
            

            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Average());




        }
    }
}
