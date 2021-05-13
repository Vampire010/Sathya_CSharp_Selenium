using System;
namespace Demo_Project1.Variables_Examples
{
    public class Var_Ex2
    {
   


        static void Mains(string[] args)
        {
            var Name = "Girish";
            var _Intail = 'M';

            var age = 30;
            var salary = 50400.36;

            Console.WriteLine(" Emp_Name : " + Name + " " + _Intail);
            Console.WriteLine(" Emp_Name Data Type: " + Name.GetType());

            Console.WriteLine(" Emp_Age : " + age);
            Console.WriteLine(" Emp_salary : " + salary);

        }
    }
}
