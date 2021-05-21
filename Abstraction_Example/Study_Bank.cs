using System;
namespace Demo_Project1.Abstraction_Example
{
    public interface Study_Bank : State_Gov , Central_Govt
    {
        public void Person_Photo();

        public void Person_Name(string P_Name);


        public void Person_Dob(int p_date ,int p_month ,int p_Year);


        public void Person_Address(string P_Address ,int pincode);
        

    }
}
