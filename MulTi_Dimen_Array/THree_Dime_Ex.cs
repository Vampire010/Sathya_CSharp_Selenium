using System;
namespace Demo_Project1.MulTi_Dimen_Array
{
    public class THree_Dime_Ex
    {
        static void Mains(string[] args)
        {
            int[,,] arr3d1 = new int[1, 2, 2]
                                    {
                                        { { 1 , 2}, { 3, 4} }
                                    };


            int[,,] arr3d2 = new int[2, 2, 2]
                                    {
                                        { { 1 , 2}, { 3, 4} },
                                        { { 5 , 6}, { 7, 8} }
                                    };

            Console.WriteLine(arr3d2[1, 0, 0]);
            Console.WriteLine(arr3d2[0, 1, 1]);

            Console.WriteLine(arr3d2[0, 1, 0]);



        }

    }
}
