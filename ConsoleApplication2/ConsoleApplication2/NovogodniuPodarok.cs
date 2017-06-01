using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NovogodniuPodarok
    {
        private string _packageType;
        private string _packageColour;
        private int kolvo_sladosti = 0;
        private int total_Weight = 0;
        ProductCalculator calculator = new ProductCalculator();
       

        protected List<Sladosti> list_of_sladosti = new List<Sladosti>();

        public string PackageType
        {
            get { return _packageType; }
            set { _packageType = value; }
        }

        public string PackageColour
        {
            get { return _packageColour; }
            set { _packageColour = value; }
        }

        public int CountWeight()
        {
            for (int i = 0; i < list_of_sladosti.Count; i++)
            {

                total_Weight = total_Weight + calculator.GetTotalWeight(list_of_sladosti[i]);
                 

            }
            return total_Weight;
        }
     

        public void AddSladosti(Sladosti _sladost)
        {
            list_of_sladosti.Add(_sladost);
            kolvo_sladosti += 1;
        }
        
    }
}
