using System;
namespace Demo_Project1.Exception_Handling
{
    public class Example1
    {
        static void Mains(string[] args)
        {
            int a = 10;
            int b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
           

            

            try
            {
                int c = a + b;
                Console.WriteLine(c);
            }
            finally
            {
                Console.WriteLine(" Im Always Excuted");
            }

            int d = a + b;
            Console.WriteLine(d);

        }
    }
}
