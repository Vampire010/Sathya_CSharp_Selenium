using System;
namespace Demo_Project1.Classes_Objects
{
    public class Fruits
    {

      static  string  seed_Fruit = "seed_Fruits";
      static  string seedless_Fruit = "seedless_Fruits";

        public void seed_Fruits(String Seed_type)
        {
            Console.WriteLine("You Have Apple");
        }

        public void seedless_Fruits(String Seed_Type)
        {
            Console.WriteLine("You Have Bannana ");
        }

        static void Mains(string[] args)
        {
            Fruits frt = new Fruits();
            frt.seed_Fruits(seed_Fruit);
            frt.seedless_Fruits(seedless_Fruit);

        }
    }
}
