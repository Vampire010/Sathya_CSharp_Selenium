using System;
namespace Demo_Project1.Variables_Examples
{
    public class Var1_Ex
    {
        static String Name ;
        static Char Intail ;
        static int age = 30;
        static double salary = 50400.36;

        static void Mains(string[] args)
        {
       

            Name = "Girish";
            Intail = 'M';


            salary = 50100;
            Console.WriteLine( " Emp_Name : " + Name + " " + Intail);



            
            Console.WriteLine(" Emp_Age : " + age);
            Console.WriteLine(" Emp_salary : " + salary);


        }
    }
}
