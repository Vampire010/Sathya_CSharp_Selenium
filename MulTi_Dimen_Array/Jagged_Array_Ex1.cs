using System;
namespace Demo_Project1.MulTi_Dimen_Array
{
    public class Jagged_Array_Ex1
    {
        static void Main(string[] args)
        {
            int[][,] jArray = new int[2][,];

            jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };


            Console.WriteLine(jArray[0][ 1 , 1 ]);

            Console.WriteLine(jArray[1][1, 1]);


            Console.WriteLine(jArray[1][0, 0]);

        }
    }
}
