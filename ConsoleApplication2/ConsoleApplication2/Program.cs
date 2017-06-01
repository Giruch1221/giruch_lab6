using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Timers;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int kolvoSladost;
            int sladost;
            NovogodniuPodarok podarok = new NovogodniuPodarok();
  

            kolvoSladost = rand.Next(20)+1;

            Console.WriteLine("Подарок состоит из: ");
            for (int i=1; i<= kolvoSladost; i++)
            {
                sladost = rand.Next(2) + 1;
                switch (sladost)
                {
                    case 1:
                        Banana b = new Banana(rand.Next(17) + 10, "банан ");
                        podarok.AddSladosti(b);
                        Console.WriteLine("Название = " + b.Name+ " за вес: " + b.Weight);
                        break;
                    case 2:
                        Yabloko y = new Yabloko(rand.Next(15) + 10, "Яблоко");
                        podarok.AddSladosti(y);
                        Console.WriteLine("Название = " + y.Name+ " за вес: " + y.Weight);
                        break;
                    case 3:
                        ChupaChups c = new ChupaChups(rand.Next(7) + 10, "ChupaChups");
                        podarok.AddSladosti(c);
                        Console.WriteLine("Название = " + c.Name + " за вес: " + c.Weight);
                        break;
                    case 4:
                        Alenka a = new Alenka(rand.Next(20) + 10, "Аленка");
                        podarok.AddSladosti(a);
                        Console.WriteLine("Название = " + a.Name + " за вес: " + a.Weight);
                        break;
                }
            }

         
            int Weight = podarok.CountWeight();
           Console.WriteLine("Weight = " + Weight);
            Console.ReadKey();
        }
    }
}
