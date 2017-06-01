using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Konfety:Sladosti
    {
        private double _calories;
        private string _tupe;
        public Konfety(int p, string n) : base(p,n) { }
        public double Calories
        {
            get { return _calories; }
            set { _calories = value; }
        }

        public string Tupe
        {
            get { return _tupe; }
            set { _tupe = value; }
        }

    }
}
