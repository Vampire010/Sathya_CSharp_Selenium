using System;
namespace Demo_Project1.Control_STructures
{
    public class For_Ex
    {
        static void Mains(string[] args)
        {
         /*   for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i = {0}", i);
            } */

           
                for (int i = 0; i < 2; i++)
                {
                    for (int j = i; j < 4; j++)
                    {
                        Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
                    }
                }
            
        }
    }
}
