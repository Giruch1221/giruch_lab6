using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Frukty:Sladosti
    {
        private double _supplierContry;
        private bool _fresh;

        public Frukty(int p, string n) : base(p, n) { }

        public double Calories
        {
            get { return _supplierContry; }
            set { _supplierContry = value; }
        }

        public bool Fresh
        {
            get { return _fresh; }
            set { _fresh = value; }
        }
        public override void TheWayToEat()
        {
            Console.WriteLine("Жуем");

        }
    }
}
