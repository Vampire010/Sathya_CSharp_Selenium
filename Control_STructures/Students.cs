using System;
namespace Demo_Project1.Control_STructures
{
    public class Students
    {
        static void Mains(string[] args)
        {
            int percentages = 96;
            if (percentages >= 0 && percentages <= 100)
            {
                if (percentages >= 85)
                {
                    if (percentages >= 97 && percentages <= 100)
                    {
                        Console.WriteLine("College Toper");
                    }
                    else
                    {
                        Console.WriteLine("Rank Student");
                    }

                }
                else if (percentages >= 60 && percentages <= 84)
                {
                    Console.WriteLine("First Class Student");

                }

                else if (percentages >= 50 && percentages <= 59)
                {
                    Console.WriteLine("Sencond Class Student");
                }

            }


        }
    }
}
