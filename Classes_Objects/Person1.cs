using System;
namespace Demo_Project1.Classes_Objects
{
    public class Person1
    {

        public void person_state_Moves()
        {
            Console.WriteLine("Person Behavoiur while he is in Moving_State");

            Console.WriteLine("Speak , Jump , Eat , Drink , Fight , Read , Write , See");

        }
        public void person_state_sits()
        {
            Console.WriteLine("Person Behavoiur while he is in Sitting_State");

            Console.WriteLine("Speak  , Eat , Drink , Read , Write , See ");

        }


        public void person_state_sleep()
        {
            Console.WriteLine("Person Behavoiur while he is in Sleep_State");

            Console.WriteLine("Speak , Read , Write , See ");

        }


        static void Mains(string[] args)
        {
            Person1 ps1 = new Person1();
            ps1.person_state_sleep();
            ps1.person_state_sits();
            ps1.person_state_Moves();

        }
    }
}
