using System;
namespace Demo_Project1.Classes_Objects
{
    public class Calculater
    {
        public void add(int a , int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is " + c);
        }
        public void mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication is " + c);

        }

        static void Mains(string[] args)
        {
            Calculater cal = new Calculater();
            cal.add(10 , 16);
            cal.mul(60 ,10);

        }
    }
}
