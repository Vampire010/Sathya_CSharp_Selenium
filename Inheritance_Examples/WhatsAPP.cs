using System;
namespace Demo_Project1.Inheritance_Examples
{
    public class WhatsAPP : Facebook
    {
        public void WhatsAPP_V1(string status_text)
        {
            Console.WriteLine( status_text + " Status uploaded as TEXT ");
        }
        public void WhatsAPP_V1(string status_text , string status_Photo)
        {
            Console.WriteLine(" Status uploaded as TEXT , Photo");

        }
        public void WhatsAPP_V1(string status_text, int status_Video)
        {
            Console.WriteLine("Status uploaded as TEXT , status_Video ");

        }

        
        public override void Facebook_status()
        {
            Console.WriteLine("Status uploaded as Video ");

        }

        static void Main(string[] args)
        {
            WhatsAPP watsapp = new WhatsAPP();

            watsapp.WhatsAPP_V1(" Girish ");
            watsapp.WhatsAPP_V1("Girish", "Ram");
            watsapp.WhatsAPP_V1("Girish", 24);
            watsapp.Facebook_status();

        }

    }
}
