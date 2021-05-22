using System;
namespace Demo_Project1.Abstraction_Example
{
    public class Person_database : Study_Bank
    {
        static void Mains(string[] args)
        {
            Person_database pd = new Person_database();
            pd.Person_Name("Girish");
            pd.Person_Dob(24 , 05 , 1992);
            pd.Person_Address("Bangalore" , 560025);
            pd.Person_Photo();
            pd.Person_Details();
            pd.Person_Nation_Identity();
        }

        public void Person_Address(string P_Address, int pincode)
        {
            Console.WriteLine(" Person P_Address : " + P_Address );
            Console.WriteLine(" Person pincode : " + pincode);

        }

        public void Person_Details()
        {
            Console.WriteLine(" Person_Details Are Verified by State Gov  ");
        }

        public void Person_Dob(int p_date, int p_month, int p_Year)
        {
            Console.WriteLine(" Person P_DOB : " + p_date +" - " + p_month +" - " + p_Year);
        }

        public void Person_Name(string P_Name)
        {
            Console.WriteLine(" Person Name : " + P_Name);
        }

        public void Person_Nation_Identity()
        {
            Console.WriteLine(" Person_Nation_Identity Are Verified by Central Gov  ");
        }

        public void Person_Photo()
        {
            Console.WriteLine(" Person Photo_Uploaded ");
        }
    }
}
