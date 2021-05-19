using System;
namespace Demo_Project1.Enumerations_ex
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class Enumerations_ex1
    {


        static void Mains(string[] args)
        {
            Console.WriteLine(WeekDays.Monday); // Monday
            Console.WriteLine(WeekDays.Tuesday); // Tuesday
            Console.WriteLine(WeekDays.Wednesday); // Wednesday
            Console.WriteLine(WeekDays.Thursday); // Thursday
            Console.WriteLine(WeekDays.Friday); // Friday
            Console.WriteLine(WeekDays.Saturday); // Saturday
            Console.WriteLine(WeekDays.Sunday); // Sunday

            int day = (int)WeekDays.Friday; // enum to int conversion

            Console.WriteLine(day); //output: 4

            var wd = (WeekDays)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday

        }
    }
}
