using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Factory
    {
        public static NovogodniuPodarok CreateNovogodniuPodarok()
        {
            NovogodniuPodarok podarok = new NovogodniuPodarok();
            /*   Random rand = new Random();
               NovogodniuPodarok podarok = new NovogodniuPodarok();

               int kolvoSladosti;
               int sladost;
               kolvoSladosti = rand.Next(50);

               Alenka alenka = new Alenka();
               alenka.Weight = 12;
               alenka.Weight = 10;
               alenka.Name = "конфета Aленка";
               podarok.AddSladosti(alenka);


               Banana banan = new Banana();
               banan.Weight = 25;
               banan.Length = 20;
               banan.Name = "Банан";
               podarok.AddSladosti(banan);

               Yabloko yabloko = new Yabloko();
               yabloko.Weight = 25;
               yabloko.Diameter = 20;
               yabloko.Name = "Яблоко";
               podarok.AddSladosti(yabloko);



               // podarok.AddSladosti(alenka);
              // podarok.AddSladosti(banan);
             // podarok.AddSladosti(banan);*/


             return podarok;
        }
    }
}
