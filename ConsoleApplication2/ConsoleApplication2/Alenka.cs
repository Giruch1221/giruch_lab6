using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Alenka:Konfety
    {

        private string _manufacturer;
        public Alenka(int p, string n) : base(p,n) { }
      

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

      
        public override void TheWayToEat()
        {
            Console.WriteLine("Кусаем");
           
        }
    }
}
