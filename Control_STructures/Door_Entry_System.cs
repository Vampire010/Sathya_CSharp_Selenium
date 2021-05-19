using System;
namespace Demo_Project1.Control_STructures
{
    public class Door_Entry_System
    {
        static void Mains(string[] args)
        {
            double person_id = 2.4 ;

            if (person_id % 2 == 0)
            {

                Console.WriteLine("Access Granted ");
                Console.WriteLine("Access Granted  class 1");


            }

            else if (person_id % 1 == 0)
            {
                Console.WriteLine("Access Granted class 2");

            }

            else
            {
                Console.WriteLine("Access Denied");
            }


        }
    }
}
