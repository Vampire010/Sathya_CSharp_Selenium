using System;
namespace Demo_Project1.Arrays_Example
{
    public class Array_Example_1
    {
        static void Mains(string[] args)
        {

           // int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };


            int[] evenNums = new int[5] { 25, 40, 65, 98, 100 };

            for (int i = 0; i < evenNums.Length; i++)
            {
                Console.WriteLine(evenNums[i]);
            }
           
        }
    }
}
