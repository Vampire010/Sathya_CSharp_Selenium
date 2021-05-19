using System;
namespace Demo_Project1.Contructer_Example
{
    public class Addition
    {
        public Addition()
        {
            int c = 10 + 20;
            Console.WriteLine("Addition in  Constructer_1 : " + c);

        }
        public Addition(int a , int b)
        {
            int c = a - b;
            Console.WriteLine("Substraction in  Constructer_2 : " + c);

        }

        public Addition(double a, int b)
        {
            double c = a * b;
            Console.WriteLine("Multiplication in  Constructer_3 : " + c);

        }

        public Addition(int a, double b)
        {
            double c = a / b;
            Console.WriteLine("Divison in  Constructer_4 : " + c);

        }

        static void Mains(string[] args)
        {

            Addition add = new Addition();


            Addition sub = new Addition(10, 20);

            Addition mul = new Addition(12.34 , 10);

            Addition div = new Addition(10 , 2.5);



        }
    }
}
