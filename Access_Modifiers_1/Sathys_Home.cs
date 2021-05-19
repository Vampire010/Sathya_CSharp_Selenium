using System;
namespace Demo_Project1.Access_Modifiers_1
{
    public class Sathys_Home
    {

        private string visitor = " Palla ";

        protected string Table_no = " B - 12 ";

        public void Inviation_Message()
        {
            Console.WriteLine("Hi " + visitor + " your invited for B'day Party at our Home" );
            Console.WriteLine("Your Table Number is: " + Table_no);

        }


        static void Mains(string[] args)
        {
            Sathys_Home home = new Sathys_Home();

            home.Inviation_Message();

        }
    }
}
