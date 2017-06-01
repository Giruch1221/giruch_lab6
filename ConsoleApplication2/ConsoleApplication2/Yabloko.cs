using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Yabloko:Frukty
    {
        private string _color;
        private string _sort;
        private int _diameter;

        public Yabloko(int p, string n) : base(p,n) { }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string Sort
        {
            get { return _color; }
            set { _color = value; }
        }
        public int Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }
    }
}
