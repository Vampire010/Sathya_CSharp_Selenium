using System;
namespace Demo_Project1.MulTi_Dimen_Array
{
    public class Jagged_Array_Ex
    {
        static void Mains(string[] args)
        {
            int[][] jArray = new int[2][]
                                    {
                                        new int[3]{1, 2, 3},
                                        new int[4]{4, 5, 6, 7},

                                    };

            Console.WriteLine(jArray[0][0]);
            Console.WriteLine(jArray[0][2]);

            Console.WriteLine(jArray[1][2]);
            Console.WriteLine(jArray[1][0]);


        }
    }
}
