using System;
namespace Demo_Project1.Enumerations_ex
{
    struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }

    public class Structure_ex1
         {
       
         static void Mains(string[] args)
            {
                Coordinate point;
              //  Console.Write(point.x); // Compile time error
                point.x = 10;
                point.y = 20;
                Console.WriteLine(point.x); //output: 10
                Console.WriteLine(point.y); //output: 20



            Console.WriteLine("*****#######*******"); 


            Coordinate point1 = new Coordinate(15, 80);
            Console.WriteLine(point1.x); //output: 10
            Console.WriteLine(point1.y); //output: 20
        }
    }
}
