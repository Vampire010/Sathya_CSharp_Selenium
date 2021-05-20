using System;
namespace Demo_Project1.Inheritance_Examples
{
    public class Calci_Abc_Client : Calci_Abc_Client_Multiplication
    {
        public void addition(int A , int B)
        {
            int C = A + B;
            Console.WriteLine("Addition of " + A + " + " + B + " is " + C);
        }

        public void substraction(int A, int B)
        {

            int C = A - B;
            Console.WriteLine("substraction of " + A + " - " + B + " is " + C);
        }

        static void Mains(string[] args)
        {
            Calci_Abc_Client calci = new Calci_Abc_Client();
            calci.addition(10 , 15);
            calci.substraction( 12, 8);
            calci.Multiplication(12, 10);
            calci.Divison(15 , 2.5);

        }
    }
}
