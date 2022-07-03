using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLib
{
    public class TaxRate
    {
        public double Rate { get; set; } = .1;

        public TaxRate() { }

        public void UpdateRate(double rate) //Will call this method to change Tax Rate
        {
            Rate = rate;
        }

       




    }
}
