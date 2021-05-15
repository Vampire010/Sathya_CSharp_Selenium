using System;
namespace Demo_Project1.MulTi_Dimen_Array
{
    public class Two_Dimenensional_Ex1
    {
        static void Mains(string[] args)
        {

            int[ , ] arr2d = new int[3, 2]{
                                             {1, 2},
                                             {3, 4},
                                             {5, 6}
                                         };


            Console.WriteLine( arr2d[2 , 0] );
            Console.WriteLine(arr2d[0, 1]);

            Console.WriteLine( arr2d[1,1]) ;


        }
    }
}
