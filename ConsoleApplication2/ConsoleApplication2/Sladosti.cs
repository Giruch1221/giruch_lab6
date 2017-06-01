using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Sladosti
    {
        //private double _weight;
        private int _Weight;
        private string _name;
        public Sladosti() { }
        public abstract void TheWayToEat();

        public Sladosti(int p, string n)
        {
            this.Weight = p;
            this.Name = n;
        }
        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

       /* public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }*/
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
