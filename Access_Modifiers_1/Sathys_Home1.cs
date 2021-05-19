using System;
namespace Demo_Project1.Access_Modifiers_1
{
    public class Sathys_Home1 : Sathys_Home
    {

        public void Inviation_Message1()
        {
            //Console.WriteLine("Hi " + visitor + " your invited for  Party at our Home");

            Console.WriteLine("Your Table Number is: " + Table_no);


        }


        static void Main(string[] args)
        {
            Sathys_Home1 home1 = new Sathys_Home1();
            home1.Inviation_Message1();

        }
    }
}
