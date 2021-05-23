using System;
using System.Collections;

namespace Demo_Project1.Collections_ArrayList
{
    public class ArrayList_ex1
    {
        static void Mains(string[] args)
        {
            ArrayList arlist = new ArrayList();
            arlist.Add(1);
            arlist.Add("Bill");
            arlist.Add(" ");
            arlist.Add(true);
            arlist.Add(4.5);
            arlist.Add(null);

            ArrayList arlist1 = new ArrayList();
            arlist1.Add(2);
            arlist1.Add("Girish");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(9.5);
            arlist1.Add(null);
            arlist[0] = "Steve";
            arlist1.Add(arlist);

            


            foreach (var arr in arlist1)
                {
                    Console.WriteLine(arr);
                }


            Console.WriteLine(" ind "+ arlist[0]);
            Console.WriteLine(arlist.Contains("Bill"));

            Console.WriteLine(arlist.Capacity);
            Console.WriteLine(arlist.Count);



        }
    }
}
