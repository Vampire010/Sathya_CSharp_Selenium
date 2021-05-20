using System;
namespace Demo_Project1.Inheritance_Examples
{
    public class Calci_Abc_Client_Multiplication : Calci_Abc_Client_Divison
    {
        public void Multiplication(int A, int B)
        {
            int C = A * B;

            Console.WriteLine("Multiplication of " + A + " * " + B + " is " + C);

        }
    }
}
