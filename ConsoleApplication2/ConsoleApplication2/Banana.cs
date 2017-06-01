using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Banana : Frukty
    {
        private int _length;

        public Banana(int p, string n) : base(p,n) { }
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
    }
}
