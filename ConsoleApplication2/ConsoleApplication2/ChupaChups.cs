using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class ChupaChups : Konfety
    {

        private string _dateManufacture;
        public ChupaChups(int p, string n) : base(p,n) { }
       
        public string Manufacturer
        {
            get { return _dateManufacture; }
            set { _dateManufacture = value; }
        }


        public override void TheWayToEat()
        {
            Console.WriteLine("Сосём");

        }
    }
}
