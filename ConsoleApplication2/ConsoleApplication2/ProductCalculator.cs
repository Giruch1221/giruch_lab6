using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    class ProductCalculator
    {
        public int GetTotalWeight(Sladosti sladost)
        {
            int totalWeight;
            totalWeight = sladost.Weight;
            return totalWeight;
        }
    }
}
