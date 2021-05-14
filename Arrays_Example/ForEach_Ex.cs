using System;
namespace Demo_Project1.Arrays_Example
{
    public class ForEach_Ex
    {
        static void Mains(string[] args)
        {
            String[] City = new String[5] { "Mumbai", "London", "New_York" ,"Bangalore" , "Mysore"};

            foreach (String Get_City_Name in City)
            {
                Console.Write(" City Name : " + Get_City_Name + " , ");

            }

            int[] city_Code = new int[5] { 2, 5, 7, 12 , 16 };

            foreach (int Get_City_Code in city_Code)
            {
                Console.Write( " City Code  : " + Get_City_Code + " , ");

            }



            foreach (int Get_City_Code in city_Code)
            {
                Console.Write(" City Code  : " + Get_City_Code + " , ");



                foreach (String Get_City_Name in City)
                {
                    Console.WriteLine(Get_City_Name+ " - " + Get_City_Code );

                }

            }

        }
    }
}
