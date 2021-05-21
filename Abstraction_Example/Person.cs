using System;
namespace Demo_Project1.Abstraction_Example
{
    abstract public class Person
    {
        abstract public void Person_Photo();

        public void Person_Name(string P_Name)
        {
            Console.WriteLine(" Person Name : " + P_Name);
        }

        public void Person_Dob(string P_DOB)
        {
            Console.WriteLine(" Person P_DOB : " + P_DOB);

        }

        public void Person_Address(string P_Address)
        {
            Console.WriteLine(" Person P_Address : " + P_Address);

        }

        

    }
}
