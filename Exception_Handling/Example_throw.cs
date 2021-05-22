using System;
namespace Demo_Project1.Exception_Handling
{
    public class Example_throw
    {
        public static void custom_exception()
        {
            throw new NullReferenceException(" object is null.");
        }



        static void Mains(string[] args)
        {

            int a = 10;
            int b = 0;
            custom_exception();
            Console.WriteLine(a + b);
        }
    }
}
